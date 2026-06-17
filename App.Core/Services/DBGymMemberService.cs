using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public class DBGymMemberService : IGymMemberService
    {
        private readonly string _connectionString;

        public DBGymMemberService(string connString)
        {
            _connectionString = connString;
        }

        async Task<GymMember> IGymMemberService.AddAsync(GymMember member)
        {
            member.Id = "GM-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "INSERT INTO GymMember(Id, Name, Phone, Email, Address, [Plan], [Status], JoinDate) VALUES (@Id, @Name, @Phone, @Email, @Address, @Plan, @Status, @JoinDate)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", member.Id);
                cmd.Parameters.AddWithValue("@Name", member.Name);
                cmd.Parameters.AddWithValue("@Phone", member.Phone ?? "");
                cmd.Parameters.AddWithValue("@Email", member.Email ?? "");
                cmd.Parameters.AddWithValue("@Address", member.Address ?? "");
                cmd.Parameters.AddWithValue("@Plan", member.Plan.ToString());
                cmd.Parameters.AddWithValue("@Status", member.Status.ToString());
                cmd.Parameters.AddWithValue("@JoinDate", member.JoinDate);
                int rows = await cmd.ExecuteNonQueryAsync();
                return rows > 0 ? member : null;
            }
        }

        async Task<bool> IGymMemberService.UpdateAsync(GymMember member)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "UPDATE GymMember SET Name=@Name, Phone=@Phone, Email=@Email, Address=@Address, [Plan]=@Plan, [Status]=@Status, JoinDate=@JoinDate WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", member.Id);
                cmd.Parameters.AddWithValue("@Name", member.Name);
                cmd.Parameters.AddWithValue("@Phone", member.Phone ?? "");
                cmd.Parameters.AddWithValue("@Email", member.Email ?? "");
                cmd.Parameters.AddWithValue("@Address", member.Address ?? "");
                cmd.Parameters.AddWithValue("@Plan", member.Plan.ToString());
                cmd.Parameters.AddWithValue("@Status", member.Status.ToString());
                cmd.Parameters.AddWithValue("@JoinDate", member.JoinDate);
                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }

        async Task<bool> IGymMemberService.DeleteAsync(string id)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("DELETE FROM GymMember WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }

        async Task<GymMember> IGymMemberService.GetByIdAsync(string id)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM GymMember WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync()) return ReadMember(reader);
                }
            }
            return null;
        }

        async Task<List<GymMember>> IGymMemberService.GetAllAsync()
        {
            List<GymMember> members = new List<GymMember>();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM GymMember ORDER BY Name", conn);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) members.Add(ReadMember(reader));
                }
            }
            return members;
        }

        async Task<List<GymMember>> IGymMemberService.SearchAsync(string text, MembershipPlanEnum? plan, MemberStatusEnum? status)
        {

            {

                List<GymMember> members = new List<GymMember>();
                await using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    string sql = @"SELECT * FROM GymMember 
                       WHERE (
                           Name    LIKE @text OR 
                           Phone   LIKE @text OR 
                           Address LIKE @text OR 
                           Email   LIKE @text OR
                           [Plan]  LIKE @text OR
                           [Status] LIKE @text
                       )";

                    if (plan != null)
                        sql += " AND [Plan]=@plan";

                    if (status != null)
                        sql += " AND [Status]=@status";

                    sql += " ORDER BY Name";

                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@text", "%" + (text ?? "").Trim() + "%");

                    if (plan != null)
                        cmd.Parameters.AddWithValue("@plan", plan.ToString());

                    if (status != null)
                        cmd.Parameters.AddWithValue("@status", status.ToString());

                    await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync()) members.Add(ReadMember(reader));
                    }
                }
                return members;
            }

        }

        private GymMember ReadMember(SqlDataReader reader)
        {
            GymMember m = new GymMember();
            m.Id = reader["Id"].ToString();
            m.Name = reader["Name"].ToString();
            m.Phone = reader["Phone"].ToString();
            m.Email = reader["Email"].ToString();
            m.Address = reader["Address"].ToString();
            m.Plan = Enum.TryParse<MembershipPlanEnum>(reader["Plan"].ToString(), true, out var plan) ? plan : MembershipPlanEnum.Basic;
            m.Status = Enum.TryParse<MemberStatusEnum>(reader["Status"].ToString(), true, out var status) ? status : MemberStatusEnum.Active;
            m.JoinDate = Convert.ToDateTime(reader["JoinDate"]);
            return m;
        }
    }
}