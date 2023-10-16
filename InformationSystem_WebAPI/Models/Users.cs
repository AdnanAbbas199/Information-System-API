using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InformationSystem_WebAPI.Models
{
    public class Users
    {
        public Users() { }

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(50)")]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(15)")]
        public string Phone { get; set; } = string.Empty;


    }
}
