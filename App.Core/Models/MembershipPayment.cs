using App.Core.Utilities;
using System;

namespace App.Core.Models
{
    public class MembershipPayment
    {
        public string Id { get; set; }
        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public string TrainerId { get; set; }
        public string TrainerName { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? DueDate { get; set; }
        public PaymentStatusEnum Status { get; set; }

        public MembershipPayment()
        {
            Id = "P-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            Status = PaymentStatusEnum.Pending;
        }
    }
}