using System.ComponentModel.DataAnnotations.Schema;

namespace CCFp1.Models
{
    public class ApplicantEx
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public string Designation {  get; set; }
        public int YearofEx { get; set; }
        [ForeignKey("Applicant")]
        public int ApplicantID { get; set; }
        public Applicant Applicant { get; set; }

    }
}
