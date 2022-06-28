using System.Collections.Generic;

namespace poprawa_kolokwium_S18288.Dtos
{
    public class TeamDto
    {
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public string OrganizationName { get; set; }
        public IEnumerable<MemberDto> Members { get; set; }
    }
}
