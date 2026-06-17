using App.Core.Models;
using App.Core.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Core.Contracts
{
    public interface IPaymentService
    {
        Task AddAsync(MembershipPayment payment);
        Task UpdateAsync(MembershipPayment payment);
        Task DeleteAsync(string id);
        Task<MembershipPayment> GetByIdAsync(string id);
        Task<List<MembershipPayment>> GetAllAsync();
        Task<List<MembershipPayment>> GetByMemberIdAsync(string memberId);
        Task<List<MembershipPayment>> GetByStatusAsync(PaymentStatusEnum status);
    }
}