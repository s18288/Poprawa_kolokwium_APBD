using System.Collections.Generic;

namespace poprawa_kolokwium_S18288.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public Organization Organization { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberNickName { get; set; }

        public ICollection<Membership> Memberships { get; set; }
    }
}
