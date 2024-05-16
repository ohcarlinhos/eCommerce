using eCommerce.Models;
using eCommerce_API.Database;

namespace eCommerce_API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly eCommerceContext _db;

        public UsuarioRepository(eCommerceContext db)
        {
            _db = db;
        }

        public void Add(Usuario usuario)
        {
            // unit of works
            // só é salvo no banco dados depois que for feito todas as operações.
            _db.Usuarios.Add(usuario); // ta na memoria aqui
            _db.SaveChanges(); // salva o que tava e memória no banco de dados.
        }

        public void Delete(int id)
        {
            var usuario = Get(id);

            if(usuario != null)
            {
                _db.Usuarios.Remove(usuario);
                _db.SaveChanges();
            }
        }

        public List<Usuario> Get()
        {
            return _db.Usuarios.OrderBy(u => u.Id).ToList();
        }

        public Usuario? Get(int id)
        {
            return _db.Usuarios.Find(id);
        }

        public void Update(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();
        }
    }
}
