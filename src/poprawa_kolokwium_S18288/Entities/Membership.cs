using System;
using System.ComponentModel.DataAnnotations;

namespace poprawa_kolokwium_S18288.Entities
{
    public class Membership
    {
        [Key]
        public int MembershipId { get; set; }
        public Member Member { get; set; }
        public Team Team { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
