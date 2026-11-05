using System.ComponentModel.DataAnnotations;

namespace WebAPP_Wilber_Alvarez_26._11._05.dto.requets
{
    public class UsuarioRequets
    {
        public string Username { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}
