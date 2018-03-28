using CreditAnalysisAPI.Domain.Contracts;

namespace CreditAnalysisAPI.Services.Interfaces
{
    public interface IAnalysisService
    {
        Response DoAnalysis(Request request); 
    }
}