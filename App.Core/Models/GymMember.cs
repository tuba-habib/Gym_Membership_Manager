using App.Core.Utilities;
using System;

namespace App.Core.Models
{
    public class GymMember
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public MembershipPlanEnum Plan { get; set; }
        public MemberStatusEnum Status { get; set; }
        public DateTime JoinDate { get; set; }

        public GymMember()
        {
            Id = "GM-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            JoinDate = DateTime.Now;
            Status = MemberStatusEnum.Active;
            Plan = MembershipPlanEnum.Basic;
        }
    }
}
