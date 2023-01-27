using SACM.Entities;
using SACM.Repositories;

namespace SACM.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private IEspecialidadeRepository _repository;

        public EspecialidadeService(IEspecialidadeRepository repository)
        {
            _repository = repository;
        }

        public Especialidade Create(Especialidade especialidade)
        {
            return _repository.Create(especialidade);
        }

        public Especialidade Update(int id, Especialidade especialidade)
        {
            return _repository.Update(id, especialidade);         
        }

        public bool DeleteById(int id)
        {
            return _repository.DeleteById(id);
        }

        public IEnumerable<Especialidade> FindAll()
        {
            return _repository.FindAll();
        }

        public Especialidade GetById(int id)
        {
             return _repository.GetById(id);
        }

    }
}
