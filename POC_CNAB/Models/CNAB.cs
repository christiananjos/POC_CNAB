using POC_CNAB.Enums;

namespace POC_CNAB.Models
{
    public class CNAB
    {
        public TipoTransacao TipoTransacao { get; set; }
        public string Data { get; set; }
        public string Valor { get; set; }
        public string CPF { get; set; }
        public string Cartao { get; set; }
        public string NomeDonoLoja { get; set; }
        public string NomeLoja { get; set; }
    }
}
