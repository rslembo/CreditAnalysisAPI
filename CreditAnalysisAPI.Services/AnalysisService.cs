using CreditAnalysisAPI.Domain.Dtos;
using CreditAnalysisAPI.Services.Interfaces;

namespace CreditAnalysisAPI.Services
{
    public class AnalysisService : IAnalysisService
    {
        public bool DoAnalysis(AnalysisDto analysisDto)
        {
            if (analysisDto.Cpf.Equals("12345678901"))
                return false;

            return true;
        }
    }
}