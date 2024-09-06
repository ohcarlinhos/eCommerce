using eCommerce.Models;
using eCommerce.Api.Database;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Api.Repositories
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
            CriarVinculoUsuarioDepartamento(usuario);

            // unit of works
            // só é salvo no banco dados depois que for feito todas as operações.
            _db.Usuarios.Add(usuario); // ta na memoria aqui
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var usuario = Get(id);

            if (usuario != null)
            {
                _db.Usuarios.Remove(usuario);
                _db.SaveChanges();
            }
        }

        public List<Usuario> Get()
        {
            return _db.Usuarios
                .OrderBy(u => u.Id)
                .Include(a => a.Contato)
                .ToList();
        }

        public Usuario? Get(int id)
        {
            return _db.Usuarios
                .Include(a => a.Contato)
                .Include(a => a.EnderecosEntrega)
                .Include(a => a.Departamentos)
                .FirstOrDefault(a => a.Id == id);
        }
        
        public void Update(Usuario usuario)
        {
            ExcluirVinculoUsuarioDepartamento(usuario);
            CriarVinculoUsuarioDepartamento(usuario);
            
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();
        }

        private void ExcluirVinculoUsuarioDepartamento(Usuario usuario)
        {
            var usuarioDb = _db.Usuarios
                .Include(a => a.Departamentos)
                .FirstOrDefault(u => u.Id == usuario.Id);

            // removendo vínculos
            foreach (var departamento in usuarioDb.Departamentos!)
            {
                usuarioDb.Departamentos.Remove(departamento);
            }

            _db.SaveChanges();
            
            // Limpando o acompanhamento do objeto na memória.
            // É necessário para não dar problema ao atualizar o mesmo no banco
            // já que o mesmo será atualizando com o que veio via param.
            _db.ChangeTracker.Clear();
        }

        private void CriarVinculoUsuarioDepartamento(Usuario usuario)
        {
            if (usuario.Departamentos != null)
            {
                var departamentos = usuario.Departamentos;
                usuario.Departamentos = new List<Departamento>();

                foreach (var departamento in departamentos)
                {
                    if (departamento.Id > 0)
                    {
                        // Ref objeto do banco de dados
                        usuario.Departamentos.Add(_db.Departamentos.Find(departamento.Id)!);
                    }
                    else
                    {
                        // Ref de novo objeto que será criado.
                        usuario.Departamentos.Add(departamento);
                    }
                }
            }
        }
    }
}