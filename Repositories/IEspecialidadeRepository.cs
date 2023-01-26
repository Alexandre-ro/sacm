using SACM.Entities;

namespace SACM.Repositories
{
    public interface IEspecialidadeRepository
    {
        Especialidade GetById(int id);
        IEnumerable<Especialidade> FindAll();
        Especialidade Create(Especialidade especialidade);
        Especialidade Update(int id, Especialidade especialida);
        bool DeleteById(int id);
    }
}
