namespace new_bs_integra.Models
{
    public class UserUpdate
    {
        public int IdVendedor { get; set; }
        public int IdFuncionario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public byte UserMasterOurOperador { get; set; }
        public decimal DescontoMaximoRodape { get; set; }
        public string StatusErp { get; set; }
    }
}
