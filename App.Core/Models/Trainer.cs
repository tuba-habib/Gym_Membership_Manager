using System;

namespace App.Core.Models
{
    public class Trainer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }

        public Trainer()
        {
            Id = "T-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
        }
    }
}
