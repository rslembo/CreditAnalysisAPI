using System;

namespace CreditAnalysisAPI.Contracts
{
    public class Request
    {
        public string NomeCompleto { get; set; }
        public string NomeMaeCompleto { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}