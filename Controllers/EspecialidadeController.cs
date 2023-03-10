using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SACM.Entities;
using SACM.Services;

namespace SACM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : ControllerBase
    {
        private IEspecialidadeService _service;
        public EspecialidadeController(IEspecialidadeService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CriarEspecialidade([FromBody] Especialidade especialidade)
        {
            try
            {
                if (_service.Create(especialidade) == null)
                {
                    return BadRequest("Já existe uma Especialidade com este nome!");
                }

                return Ok(especialidade);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarEspecialidade([FromBody] Especialidade especialidade, int id)
        {
            try
            {
                if (id <= 0 || especialidade.Codigo != id)
                {
                    return BadRequest("O Código informado é inválido!");
                }

                if (_service.Update(id, especialidade) == null)
                {
                    return StatusCode(500, "Não é possível atualizar com o ID e Nome informados!");
                }

                return Ok(especialidade);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarEspecialidade(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("O ID informado é inválido!");
                }

                if (_service.DeleteById(id) == false)
                {
                    return StatusCode(500, "ocorreu um erro no Servidor!");
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarEspecialidePorId(int id)
        {
            try
            {
                Especialidade especialidade = _service.GetById(id);

                return Ok(especialidade);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult BuscarEspecialidades()
        {
            try
            {
                IEnumerable<Especialidade> especialidades;

                especialidades = _service.FindAll();

                return Ok(especialidades);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
