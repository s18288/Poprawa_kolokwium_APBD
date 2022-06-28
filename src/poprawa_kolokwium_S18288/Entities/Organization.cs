using System.Collections.Generic;

namespace poprawa_kolokwium_S18288.Entities
{
    public class Organization
    {
        public int OranizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDomain { get; set; }
    
        public ICollection<Team> Teams { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
