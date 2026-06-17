using App.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Core.Contracts
{
    public interface ITrainerService
    {
        Task AddAsync(Trainer trainer);
        Task UpdateAsync(Trainer trainer);
        Task DeleteAsync(string id);
        Task<Trainer> GetByIdAsync(string id);
        Task<List<Trainer>> GetAllAsync();
        Task<List<Trainer>> SearchAsync(string query);
    }
}