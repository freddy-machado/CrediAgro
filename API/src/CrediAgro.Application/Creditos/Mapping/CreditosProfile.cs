using AutoMapper;
using CrediAgro.Contracts.Dtos.Creditos;
using CrediAgro.Infrastructure.Persistence.CustomEntities;

namespace CrediAgro.Application.Creditos.Mapping;

public sealed class CreditosProfile : Profile
{
    public CreditosProfile()
    {
        CreateMap<CreditoList, CreditoListItemDto>()
            .ForMember(d => d.CreditoId, o => o.MapFrom(s => s.creditoID))
            .ForMember(d => d.NumeroSolicitud, o => o.MapFrom(s => s.numeroSolicitud))
            .ForMember(d => d.Cliente, o => o.MapFrom(s => s.cliente))
            .ForMember(d => d.FechaSolicitud, o => o.MapFrom(s => s.fechaSolicitud))
            .ForMember(d => d.Rubro, o => o.MapFrom(s => s.rubro))
            .ForMember(d => d.MontoSolicitado, o => o.MapFrom(s => s.montoSolicitado))
            .ForMember(d => d.MontoAprobado, o => o.MapFrom(s => s.montoAprobado))
            .ForMember(d => d.EstadoSolicitud, o => o.MapFrom(s => s.estadoSolicitud))
            .ForMember(d => d.Moneda, o => o.MapFrom(s => s.moneda))
            .ForMember(d => d.ClienteId, o => o.MapFrom(s => s.clienteId));
    }
}
