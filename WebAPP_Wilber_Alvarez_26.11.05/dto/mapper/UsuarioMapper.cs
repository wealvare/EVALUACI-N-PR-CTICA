using WebAPP_Wilber_Alvarez_26._11._05.dto.requets;
using WebAPP_Wilber_Alvarez_26._11._05.dto.response;
using WebAPP_Wilber_Alvarez_26._11._05.models;

namespace WebAPP_Wilber_Alvarez_26._11._05.dto.mapper
{
    public class UsuarioMapper
    {
        public Usuario toEntity(UsuarioRequets Dto)
        {
            return new Usuario
            {
                Username = Dto.Username,
                Email = Dto.Email,
                PasswordHash = Dto.PasswordHash,
            };
        } 

        public UsuarioResponse toDto (Usuario Entity)
        {
            return new UsuarioResponse
            {
                UserId = Entity.UserId,
                Username = Entity.Username,
                Email = Entity.Email,
            };
        }
    }
}
