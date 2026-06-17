using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Contracts
{
    public interface IAttendanceService
    {
        Task AddAsync(Attendance attendance);
        Task UpdateAsync(Attendance attendance);
        Task DeleteAsync(string id);
        Task<Attendance> GetByIdAsync(string id);
        Task<List<Attendance>> GetAllAsync();
        Task<List<Attendance>> GetByMemberIdAsync(string memberId);
        Task<List<Attendance>> SearchAsync(string query);
    }
}