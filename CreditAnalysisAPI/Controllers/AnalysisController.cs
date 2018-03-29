using CreditAnalysisAPI.Contracts;
using CreditAnalysisAPI.Domain.Dtos;
using CreditAnalysisAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CreditAnalysisAPI.Controllers
{
    [Route("api/[controller]")]
    public class AnalysisController : Controller
    {
        private readonly IOptions<AppConfiguration> _appConfiguration;
        private readonly IAnalysisService _analysisService;

        public AnalysisController(IOptions<AppConfiguration> appConfiguration, IAnalysisService analysisService)
        {
            _appConfiguration = appConfiguration;
            _analysisService = analysisService;
        }

        [HttpPost]
        public ActionResult Post([FromBody]Request request)
        {
            // var key = _appConfiguration.Value.XApiKey;

            var dto = ConvertRequestToAnalysisDto(request);
            var response = _analysisService.DoAnalysis(dto);

            return Ok(response);
        }

        // TODO: AutoMapper
        private AnalysisDto ConvertRequestToAnalysisDto(Request request)
        {
            return new AnalysisDto
            {
                Cpf = request.Cpf,
                DataNascimento = request.DataNascimento,
                NomeCompleto = request.NomeCompleto,
                NomeMaeCompleto = request.NomeMaeCompleto,
                Rg = request.NomeMaeCompleto
            };
        }
    }
}