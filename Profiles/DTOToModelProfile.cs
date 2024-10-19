namespace PB.AutoMapper.Profiles
{
    public class DTOToModelProfile : Profile
    {
        public DTOToModelProfile()
        {
            CreateMap<ProdutoDTO, Produto>();

            CreateMap<UsuarioDTO, Usuario>();
        }
    }
}
