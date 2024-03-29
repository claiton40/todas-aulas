﻿using Microsoft.AspNetCore.Mvc;
using HealthClinic.Interfaces;
using HealthClinic.Repositories;
using HealthClinic.Domains;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository { get; set; }

        public ClinicaController()
        {
            _clinicaRepository = new ClinicaRepository();
        }
        /// <summary>
        /// Cadastra a clinica
        /// </summary>
        /// <param name="clinica">In forme os dado da Clinica</param>
        /// <returns>Cadastra a clinica</returns>
        [HttpPost]
        public IActionResult Post(Clinica clinica)
        {
            try
            {
                _clinicaRepository.Cadastrar(clinica);

                return StatusCode(201, clinica);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Exibe a clinica cadastrada
        /// </summary>
        /// <returns>Exibe a clinica cadastrada</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_clinicaRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
