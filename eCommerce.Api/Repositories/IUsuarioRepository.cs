using eCommerce.Models;

namespace eCommerce.Api.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Get();
        Usuario? Get(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
