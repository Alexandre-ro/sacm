using SACM.Entities;

namespace SACM.Services
{
    public interface IEspecialidadeService
    {
        Especialidade GetById(int codigo);
        IEnumerable<Especialidade> FindAll();
        Especialidade Create(Especialidade especialidade);
        Especialidade Update(int codigo, Especialidade especialida);
        bool DeleteById(int codigo);
    }
}
