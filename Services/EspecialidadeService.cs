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
            try
            {
                _repository.Create(especialidade);

                return especialidade;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Especialidade Update(int codigo, Especialidade especialidade)
        {
            try
            {
                if (codigo <= 0)
                {
                    return null;
                }

                _repository.Update(codigo, especialidade);
                return especialidade;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return false;
                }

                _repository.DeleteById(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<Especialidade> FindAll()
        {
            return _repository.FindAll();
        }

        public Especialidade GetById(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            return _repository.GetById(id);
        }

    }
}
