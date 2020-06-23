using System.ComponentModel.DataAnnotations;

namespace SpiceIt.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify a length between 4 and 8 characters")]
        public string Password { get; set; }

    }
}