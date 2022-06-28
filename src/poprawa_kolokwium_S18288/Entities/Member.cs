using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace poprawa_kolokwium_S18288.Entities
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public Organization Organization { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberNickName { get; set; }

        public ICollection<Membership> Memberships { get; set; }
    }
}
