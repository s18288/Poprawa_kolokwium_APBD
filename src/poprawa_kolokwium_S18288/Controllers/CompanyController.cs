using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using poprawa_kolokwium_S18288.Dtos;
using poprawa_kolokwium_S18288.Entities;
using poprawa_kolokwium_S18288.Persistance;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace poprawa_kolokwium_S18288.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    { 
        private readonly ILogger<CompanyController> _logger;
        private readonly CompanyDbContext _context;

        public CompanyController(ILogger<CompanyController> logger, CompanyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        [Route("{teamId}")]
        public TeamDto Get(int teamId)
        {
            var team = _context.Teams.FirstOrDefault(x => x.TeamId == teamId);

            if(team == null)
            {
                throw new ArgumentException("Unknown team ID");
            }

            var teamDto = new TeamDto
            {
                TeamDescription = team.TeamDescription,
                TeamName = team.TeamName,
                OrganizationName = team.Organization.OrganizationName,
                Members = team.Memberships.Select(x => new MemberDto
                {
                    MemberId = x.Member.MemberId,
                    MemberName = x.Member.MemberName
                }).ToList(),
            };

            return teamDto;
        }

        [HttpPost]
        [Route("{teamId}")]
        public async Task<IActionResult> AddNewMember(int teamId, [FromBody]MemberDto member)
        {
            var team = _context.Teams.FirstOrDefault(x => x.TeamId == teamId);
            var memberOrg = _context.Organizations.FirstOrDefault(x => x.OranizationId == member.MemberId);

            if(team.Organization.OranizationId != memberOrg.OranizationId)
            {
                throw new ArgumentException("Different Organization");
            }

            var newMember = new Member
            {
                MemberId = member.MemberId,
                MemberName = member.MemberName,
                Organization = memberOrg
            };

            _context.Members.Add(newMember);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
