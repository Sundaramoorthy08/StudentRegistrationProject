using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Web.Models
{
    public class Interview
    {

        [Key]
		[Required]
		[Display(Name = "Student Id")]
		public int Sno { get; set; }

        [Required]
		[Display(Name = "Student Name")]
		public String Stu_name { get; set; }

		[Display(Name = "Student Email")]
		public String Stu_email { get; set; }

		[Display(Name = "Mobile Number")]
		[Required]
        public String Stu_phone { get; set; }

		[Display(Name = "Company Name")]
		public String Company_Name { get; set; }

        [Required]
		[Display(Name = "Interview Date")]
		public DateOnly Interview_Date { get; set; }







    }
}
