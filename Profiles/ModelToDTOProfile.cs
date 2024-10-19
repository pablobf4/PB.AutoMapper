namespace PB.AutoMapper.Profiles
{
    public class ModelToDTOProfile : Profile
    {
        public ModelToDTOProfile()
        {
            CreateMap<Produto, ProdutoDTO>();

            CreateMap<Usuario, UsuarioDTO>()
                .ForMember(
                    usuarioDTO => usuarioDTO.Status,
                    memberOptions => memberOptions.MapFrom(usuario => usuario.StatusUsuario != null ? usuario.StatusUsuario.NomeStatusUsuario : null)
                ).ForMember(
                    usuarioItemListaDTO => usuarioItemListaDTO.Nome,
                    memberOptions => memberOptions.MapFrom(usuario => usuario.NomeCompletoUsuario)
                 );

        }

    }
}
