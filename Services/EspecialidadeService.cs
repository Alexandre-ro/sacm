using SACM.Entities;
using SACM.Repositories;

namespace SACM.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private readonly EspecialidadeRepository _repository;

        public EspecialidadeService(EspecialidadeRepository repository)
        {
            _repository = repository;
        }

        public Especialidade Create(Especialidade especialidade)
        {
            _repository.Create(especialidade);
            return especialidade;

        }

        public Especialidade Update(int id, Especialidade especialidade)
        {
            _repository.Update(id, especialidade);
            return especialidade;
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
