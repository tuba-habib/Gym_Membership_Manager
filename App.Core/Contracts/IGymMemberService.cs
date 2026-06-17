using App.Core.Models;
using App.Core.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Core.Contracts
{
    public interface IGymMemberService
    {
        Task<GymMember> AddAsync(GymMember member);
        Task<bool> UpdateAsync(GymMember member);
        Task<bool> DeleteAsync(string id);
        Task<GymMember> GetByIdAsync(string id);
        Task<List<GymMember>> GetAllAsync();
        Task<List<GymMember>> SearchAsync(string text, MembershipPlanEnum? plan, MemberStatusEnum? status);
    }
}