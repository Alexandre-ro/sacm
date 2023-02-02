namespace SACM.Entities
{
    public class Medico
    {
        private int Id { get; set; }
        public int CodigoEspecialidade { get; set; }
        public string Crm { get; set; }
        public string Nome { get; set; }
        public string InstituicaoFormatura { get; set; }
        public int AnoFormatura { get; set; }
        public int AnoNascimento   { get; set; }
        public int MesNascimento { get; set; }
        public int DiaNascimento { get; set; }
    }
}
