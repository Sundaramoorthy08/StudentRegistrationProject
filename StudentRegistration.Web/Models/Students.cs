using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Web.Models
{
    public class Students
    {
        
        public Guid Id { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string city { get; set; }

    }
}
