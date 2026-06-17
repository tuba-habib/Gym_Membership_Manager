using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public class DBTrainerService : ITrainerService
    {
        private readonly string _connectionString;

        public DBTrainerService(string connString)
        {
            _connectionString = connString;
        }

        async Task ITrainerService.AddAsync(Trainer trainer)
        {
            trainer.Id = "T-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "INSERT INTO Trainer(Id, Name, Phone, Email, Specialization) VALUES (@Id, @Name, @Phone, @Email, @Specialization)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", trainer.Id);
                cmd.Parameters.AddWithValue("@Name", trainer.Name);
                cmd.Parameters.AddWithValue("@Phone", trainer.Phone ?? "");
                cmd.Parameters.AddWithValue("@Email", trainer.Email ?? "");
                cmd.Parameters.AddWithValue("@Specialization", trainer.Specialization ?? "");
                await cmd.ExecuteNonQueryAsync();
            }
        }

        async Task ITrainerService.UpdateAsync(Trainer trainer)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "UPDATE Trainer SET Name=@Name, Phone=@Phone, Email=@Email, Specialization=@Specialization WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", trainer.Id);
                cmd.Parameters.AddWithValue("@Name", trainer.Name);
                cmd.Parameters.AddWithValue("@Phone", trainer.Phone ?? "");
                cmd.Parameters.AddWithValue("@Email", trainer.Email ?? "");
                cmd.Parameters.AddWithValue("@Specialization", trainer.Specialization ?? "");
                await cmd.ExecuteNonQueryAsync();
            }
        }

        async Task ITrainerService.DeleteAsync(string id)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("DELETE FROM Trainer WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                await cmd.ExecuteNonQueryAsync();
            }
        }

        async Task<Trainer> ITrainerService.GetByIdAsync(string id)
        {
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Trainer WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync()) return ReadTrainer(reader);
                }
            }
            return null;
        }

        async Task<List<Trainer>> ITrainerService.GetAllAsync()
        {
            List<Trainer> trainers = new List<Trainer>();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Trainer ORDER BY Name", conn);
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) trainers.Add(ReadTrainer(reader));
                }
            }
            return trainers;
        }

        async Task<List<Trainer>> ITrainerService.SearchAsync(string query)
        {
            List<Trainer> trainers = new List<Trainer>();
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                string sql = "SELECT * FROM Trainer WHERE Name LIKE @query OR Phone LIKE @query OR Email LIKE @query OR Specialization LIKE @query";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@query", "%" + query.Trim() + "%");
                await using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) trainers.Add(ReadTrainer(reader));
                }
            }
            return trainers;
        }

        private Trainer ReadTrainer(SqlDataReader reader)
        {
            Trainer t = new Trainer();
            t.Id = reader["Id"].ToString();
            t.Name = reader["Name"].ToString();
            t.Phone = reader["Phone"].ToString();
            t.Email = reader["Email"].ToString();
            t.Specialization = reader["Specialization"].ToString();
            return t;
        }
    }
}