using System.Collections.Generic;

namespace poprawa_kolokwium_S18288.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public Organization Organization { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }

        public ICollection<Membership> Memberships { get; set; }
        public ICollection<File> Files { get; set; }
    }
}
