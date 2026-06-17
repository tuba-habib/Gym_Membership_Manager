using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public class DBPaymentService : IPaymentService
    {
        private readonly string _connectionString;

        public DBPaymentService(string connString)
        {
            _connectionString = connString;
        }

        async Task IPaymentService.AddAsync(MembershipPayment payment)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "INSERT INTO MembershipPayment(Id, MemberId, MemberName, TrainerId, TrainerName, PaymentDate, DueDate, [Status]) VALUES (@Id, @MemberId, @MemberName, @TrainerId, @TrainerName, @PaymentDate, @DueDate, @Status)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", payment.Id);
                cmd.Parameters.AddWithValue("@MemberId", payment.MemberId);
                cmd.Parameters.AddWithValue("@MemberName", payment.MemberName ?? "");
                cmd.Parameters.AddWithValue("@TrainerId", payment.TrainerId ?? "");
                cmd.Parameters.AddWithValue("@TrainerName", payment.TrainerName ?? "");
                cmd.Parameters.AddWithValue("@PaymentDate", (object)payment.PaymentDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DueDate", (object)payment.DueDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", payment.Status.ToString());
                await cmd.ExecuteNonQueryAsync();
            }
        }

        async Task IPaymentService.UpdateAsync(MembershipPayment payment)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "UPDATE MembershipPayment SET MemberId=@MemberId, MemberName=@MemberName, TrainerId=@TrainerId, TrainerName=@TrainerName, PaymentDate=@PaymentDate, DueDate=@DueDate, [Status]=@Status WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", payment.Id);
                cmd.Parameters.AddWithValue("@MemberId", payment.MemberId);
                cmd.Parameters.AddWithValue("@MemberName", payment.MemberName ?? "");
                cmd.Parameters.AddWithValue("@TrainerId", payment.TrainerId ?? "");
                cmd.Parameters.AddWithValue("@TrainerName", payment.TrainerName ?? "");
                cmd.Parameters.AddWithValue("@PaymentDate", (object)payment.PaymentDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DueDate", (object)payment.DueDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", payment.Status.ToString());
                await cmd.ExecuteNonQueryAsync();
            }
        }

        async Task IPaymentService.DeleteAsync(string id)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("DELETE FROM MembershipPayment WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                await cmd.ExecuteNonQueryAsync();
            }
        }

        async Task<MembershipPayment> IPaymentService.GetByIdAsync(string id)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM MembershipPayment WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync()) return ReadPayment(reader);
                }
            }
            return null;
        }

        async Task<List<MembershipPayment>> IPaymentService.GetAllAsync()
        {
            List<MembershipPayment> list = new List<MembershipPayment>();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM MembershipPayment ORDER BY DueDate DESC", conn);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) list.Add(ReadPayment(reader));
                }
            }
            return list;
        }

        async Task<List<MembershipPayment>> IPaymentService.GetByMemberIdAsync(string memberId)
        {
            List<MembershipPayment> list = new List<MembershipPayment>();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM MembershipPayment WHERE MemberId=@MemberId ORDER BY DueDate DESC", conn);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) list.Add(ReadPayment(reader));
                }
            }
            return list;
        }

        async Task<List<MembershipPayment>> IPaymentService.GetByStatusAsync(PaymentStatusEnum status)
        {
            List<MembershipPayment> list = new List<MembershipPayment>();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM MembershipPayment WHERE [Status]=@Status ORDER BY DueDate DESC", conn);
                cmd.Parameters.AddWithValue("@Status", status.ToString());
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) list.Add(ReadPayment(reader));
                }
            }
            return list;
        }

        private MembershipPayment ReadPayment(SqlDataReader reader)
        {
            MembershipPayment p = new MembershipPayment();
            p.Id = reader["Id"].ToString();
            p.MemberId = reader["MemberId"].ToString();
            p.MemberName = reader["MemberName"].ToString();
            p.TrainerId = reader["TrainerId"].ToString();
            p.TrainerName = reader["TrainerName"].ToString();
            p.PaymentDate = reader["PaymentDate"] == DBNull.Value ? null : Convert.ToDateTime(reader["PaymentDate"]);
            p.DueDate = reader["DueDate"] == DBNull.Value ? null : Convert.ToDateTime(reader["DueDate"]);
            p.Status = Enum.TryParse<PaymentStatusEnum>(reader["Status"].ToString(), true, out var s) ? s : PaymentStatusEnum.Pending;
            return p;
        }
    }
}