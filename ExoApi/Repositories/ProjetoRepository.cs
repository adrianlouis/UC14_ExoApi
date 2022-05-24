using ExoApi.Contexts;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ProjetoContext _context;

        public ProjetoRepository(ProjetoContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projeto BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);

            _context.SaveChanges();
        }

        public void Atualizar(int id, Projeto projeto)
        {
            Projeto projBuscado = _context.Projetos.Find(id);

            if (projBuscado != null)
            {
                projBuscado.Titulo = projeto.Titulo;
                projBuscado.StatusProj = projeto.StatusProj;
                projBuscado.DataInicio = projeto.DataInicio;
                projBuscado.Tecnologia = projeto.Tecnologia;
            }

            _context.Projetos.Update(projBuscado);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Projeto projeto = _context.Projetos.Find(id);

            _context.Projetos.Remove(projeto);

            _context.SaveChanges();
        }
    }

}
