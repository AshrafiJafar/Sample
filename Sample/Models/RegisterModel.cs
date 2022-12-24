using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class RegisterModel
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ReytypePassword { get; set; }
    }
}
