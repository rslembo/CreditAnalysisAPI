using CreditAnalysisAPI.Domain.Dtos;

namespace CreditAnalysisAPI.Services.Interfaces
{
    public interface IAnalysisService
    {
        bool DoAnalysis(AnalysisDto analysisDto);
    }
}