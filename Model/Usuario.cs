namespace PB.AutoMapper.Model
{
    public class Usuario
    {
        public int CodigoUsuario { get; set; }
        public string NomeCompletoUsuario { get; set; }
        public string NomeReduzidoUsuario { get; set; }
        public DateTime DataStatusUsuario { get; set; }
        public string LoginAD { get; set; }
        public string MatriculaUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public StatusUsuario StatusUsuario { get; set; }
    }
}
