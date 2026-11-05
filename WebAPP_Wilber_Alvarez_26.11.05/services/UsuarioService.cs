using WebAPP_Wilber_Alvarez_26._11._05.dto.mapper;
using WebAPP_Wilber_Alvarez_26._11._05.dto.requets;
using WebAPP_Wilber_Alvarez_26._11._05.dto.response;
using WebAPP_Wilber_Alvarez_26._11._05.models;
using WebAPP_Wilber_Alvarez_26._11._05.repository;

namespace WebAPP_Wilber_Alvarez_26._11._05.services
{
    public class UsuarioService
    {
        private readonly UsuarioMapper _mapper;
        private readonly UsuarioRepository _repository;

        public UsuarioService(UsuarioMapper mapper, UsuarioRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<UsuarioResponse>> ObtenerTodo()
        {
            var usuarios = await _repository.GetAll();
            return usuarios.Select(u => _mapper.toDto(u)).ToList();
        } 

        public async Task <UsuarioResponse> Obtener (int id) {
            var usuario = await _repository.Get(id);
            if (usuario == null)
            {
                throw new KeyNotFoundException($"No existe la categoria con ID {id}.");
            }
            return _mapper.toDto(usuario);
        }

        public async Task<UsuarioResponse> Crear(UsuarioRequets dto)
        {
            var usuario = _mapper.toEntity(dto);
            var creada = await _repository.Save(usuario);

            return _mapper.toDto(creada);
        }
    }
}
