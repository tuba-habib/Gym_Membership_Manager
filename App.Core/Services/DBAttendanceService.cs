using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public class DBAttendanceService : IAttendanceService
    {

        private readonly string _connectionString;

        public DBAttendanceService(string connString)
        {
            _connectionString = connString;
        }

        async Task IAttendanceService.AddAsync(Attendance attendance)
        {
            attendance.Id = "ATT-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "INSERT INTO Attendance(Id, MemberId, MemberName, CheckInDate, CheckInTime, Notes) VALUES (@Id, @MemberId, @MemberName, @CheckInDate, @CheckInTime, @Notes)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", attendance.Id);
                cmd.Parameters.AddWithValue("@MemberId", attendance.MemberId);
                cmd.Parameters.AddWithValue("@MemberName", attendance.MemberName ?? "");
                cmd.Parameters.AddWithValue("@CheckInDate", attendance.CheckInDate);
                cmd.Parameters.AddWithValue("@CheckInTime", attendance.CheckInTime);
                cmd.Parameters.AddWithValue("@Notes", attendance.Notes ?? "");
                await cmd.ExecuteNonQueryAsync();
            }
        }

        async Task IAttendanceService.DeleteAsync(string id)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("DELETE FROM Attendance WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                await cmd.ExecuteNonQueryAsync();
            }
        }
        async Task IAttendanceService.UpdateAsync(Attendance attendance)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "UPDATE Attendance SET MemberId=@MemberId, MemberName=@MemberName, CheckInDate=@CheckInDate, CheckInTime=@CheckInTime, Notes=@Notes WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", attendance.Id);
                cmd.Parameters.AddWithValue("@MemberId", attendance.MemberId);
                cmd.Parameters.AddWithValue("@MemberName", attendance.MemberName ?? "");
                cmd.Parameters.AddWithValue("@CheckInDate", attendance.CheckInDate);
                cmd.Parameters.AddWithValue("@CheckInTime", attendance.CheckInTime);
                cmd.Parameters.AddWithValue("@Notes", attendance.Notes ?? "");
                await cmd.ExecuteNonQueryAsync();
            }
        }
        async Task<Attendance> IAttendanceService.GetByIdAsync(string id)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Attendance WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync()) return ReadAttendance(reader);
                }
            }
            return null;
        }

        async Task<List<Attendance>> IAttendanceService.GetAllAsync()
        {
            List<Attendance> list = new List<Attendance>();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Attendance ORDER BY CheckInDate DESC, CheckInTime DESC", conn);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) list.Add(ReadAttendance(reader));
                }
            }
            return list;
        }

        async Task<List<Attendance>> IAttendanceService.GetByMemberIdAsync(string memberId)
        {
            List<Attendance> list = new List<Attendance>();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Attendance WHERE MemberId=@MemberId ORDER BY CheckInDate DESC", conn);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) list.Add(ReadAttendance(reader));
                }
            }
            return list;
        }
        async Task<List<Attendance>> IAttendanceService.SearchAsync(string query)
        {
            List<Attendance> list = new List<Attendance>();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "SELECT * FROM Attendance WHERE MemberId LIKE @query OR MemberName LIKE @query OR Notes LIKE @query OR CONVERT(VARCHAR, CheckInDate, 101) LIKE @query ORDER BY CheckInDate DESC, CheckInTime DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@query", "%" + query.Trim() + "%");
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) list.Add(ReadAttendance(reader));
                }
            }
            return list;
        }
        private Attendance ReadAttendance(SqlDataReader reader)
        {
            return new Attendance
            {
                Id = reader["Id"].ToString(),
                MemberId = reader["MemberId"].ToString(),
                MemberName = reader["MemberName"].ToString(),
                CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                CheckInTime = (TimeSpan)reader["CheckInTime"],
                Notes = reader["Notes"].ToString()
            };
        }
    }
}