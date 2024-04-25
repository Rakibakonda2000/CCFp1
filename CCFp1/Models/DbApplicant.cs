using Microsoft.EntityFrameworkCore;

namespace CCFp1.Models
{
    public class DbApplicant:DbContext
    {
        public DbApplicant(DbContextOptions<DbApplicant> options):base(options) { }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ApplicantEx> ApplicantsEx { get; set;}
    }
}
