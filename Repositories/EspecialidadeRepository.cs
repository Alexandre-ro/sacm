using SACM.Data;
using SACM.Entities;

namespace SACM.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private SacmContext _context;

        public EspecialidadeRepository(SacmContext context)
        {
            _context = context;
        }

        public Especialidade GetById(int codigo)
        {

            Especialidade especialidade;
            especialidade = _context.Especialidades.FirstOrDefault(x => x.Codigo == codigo);

            return especialidade;
        }

        public IEnumerable<Especialidade> FindAll()
        {
            IEnumerable<Especialidade> especialidades;
            especialidades = _context.Especialidades.ToList();

            return especialidades;
        }

        public Especialidade Create(Especialidade especialidade)
        {
            Especialidade especialidadeBD = _context.Especialidades
                                            .FirstOrDefault(x => x.Nome.Equals(especialidade.Nome));

            if (especialidadeBD != null) 
            {
                return null;
            }

            _context.Especialidades.Add(especialidade);
            _context.SaveChanges();

            return especialidade;
        }

        public Especialidade Update(int codigo, Especialidade especialidade)
        {
            Especialidade especialidadeOld = _context.Especialidades.FirstOrDefault(x => x.Codigo == codigo);

            if (especialidadeOld == null)
            {
                return null;
            }

            Especialidade especialidadeBD;
            especialidadeBD = _context.Especialidades.FirstOrDefault(x => x.Nome.Equals(especialidade.Nome));

            if (especialidadeBD != null) 
            {
                return null;
            }                              

            especialidadeOld.Codigo = codigo;
            especialidadeOld.Nome = especialidade.Nome;

            _context.Update(especialidadeOld);
            _context.SaveChanges();

            return especialidade;
        }

        public bool DeleteById(int codigo)
        {
            Especialidade especialidade;
            especialidade = _context.Especialidades.FirstOrDefault(x => x.Codigo == codigo);

            if (especialidade == null)
            {
                return false;
            }

            _context.Especialidades.Remove(especialidade);
            _context.SaveChanges();

            return true;
        }
    }
}