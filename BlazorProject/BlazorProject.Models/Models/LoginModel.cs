using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Models.Models
{
    [Keyless]
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}