using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Login
    {
        public int ID { get; set; }
        [DisplayName("User name")]
        [Required(ErrorMessage ="This field is empty")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is empty")]
        public string Password { get; set; }


        public string loginErrorMe { get; set; }
    }
}
