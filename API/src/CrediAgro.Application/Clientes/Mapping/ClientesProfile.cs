using AutoMapper;
using CrediAgro.Contracts.Dtos.Clientes;
using CrediAgro.Infrastructure.Persistence.CustomEntities;

namespace CrediAgro.Application.Clientes.Mapping;

public sealed class ClientesProfile : Profile
{
    public ClientesProfile()
    {
        CreateMap<ClienteList, ClienteListItemDto>()
            .ForMember(d => d.ClienteId, o => o.MapFrom(s => s.clienteID))
            .ForMember(d => d.PersonaId, o => o.MapFrom(s => s.personaID))
            .ForMember(d => d.ClienteName, o => o.MapFrom(s => s.clienteName))
            .ForMember(d => d.Municipio, o => o.MapFrom(s => s.municipio))
            .ForMember(d => d.LugarTrabajo, o => o.MapFrom(s => s.lugarTrabajo))
            .ForMember(d => d.Puesto, o => o.MapFrom(s => s.puesto))
            .ForMember(d => d.Observacion, o => o.MapFrom(s => s.observacion));
    }
}
