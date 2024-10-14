using AutoMapper;
using Data.Repository.RepositoryModels.M_Appointment;
using Data.Repository.RepositoryModels.M_Evaluation;
using Domain.ModelForCreate;
using Domain.Models;
using Domain.ModelsForCreateAndUpdate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ScheduledServicesCente.Controllers
{
    [AllowAnonymous]

    [ApiController]
    [Route("api/[Controller]")]
    public class EvaluationController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IEvaluationRepository Evaluation;
        public EvaluationController(IEvaluationRepository Evaluation, IMapper mapper)
        {
            this.mapper = mapper;
            this.Evaluation = Evaluation;
        }
        [HttpPost]
        [Route("evaluation/create")]
        public ActionResult CreateEvaluation(EvaluationForCreate evaluation)
        {
            var EvaluationForCreate = mapper.Map<Evaluation>(evaluation);
            Evaluation.CreateEvaluation(EvaluationForCreate);
            return Ok();
        }
    }
}
