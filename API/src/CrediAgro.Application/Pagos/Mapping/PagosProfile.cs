using AutoMapper;
using CrediAgro.Contracts.Dtos.Pagos;
using CrediAgro.Infrastructure.Persistence.CustomEntities;

namespace CrediAgro.Application.Pagos.Mapping;

public sealed class PagosProfile : Profile
{
    public PagosProfile()
    {
        CreateMap<PagoCuotaEntity, PagoCuotaDto>()
            .ForMember(d => d.PagoId, o => o.MapFrom(s => s.PAGOID))
            .ForMember(d => d.SolicitudId, o => o.MapFrom(s => s.SOLICITUDID))
            .ForMember(d => d.FechaPago, o => o.MapFrom(s => s.FECHAPAGO))
            .ForMember(d => d.NumeroDocumento, o => o.MapFrom(s => s.NUMERODOCUMENTO))
            .ForMember(d => d.TablaPagoId, o => o.MapFrom(s => s.TABLAPAGOID))
            .ForMember(d => d.NumeroCuota, o => o.MapFrom(s => s.NUMEROCUOTA))
            .ForMember(d => d.Principal, o => o.MapFrom(s => s.PRINCIPAL))
            .ForMember(d => d.Interes, o => o.MapFrom(s => s.INTERES))
            .ForMember(d => d.Mora, o => o.MapFrom(s => s.MORA))
            .ForMember(d => d.Mantenimiento, o => o.MapFrom(s => s.MANTENIMIENTO))
            .ForMember(d => d.Total, o => o.MapFrom(s => s.TOTAL));

        CreateMap<CuotaPendientePagoGrid, CuotaPendientePagoDto>()
            .ForMember(d => d.Cuota, o => o.MapFrom(s => s.N_CUOTA))
            .ForMember(d => d.AmortizacionId, o => o.MapFrom(s => s.N_AMORTIZACION_ID))
            .ForMember(d => d.FechaPago, o => o.MapFrom(s => s.D_FECHA_PAGO))
            .ForMember(d => d.DiasVencidos, o => o.MapFrom(s => s.N_DIAS_VENCIDOS))
            .ForMember(d => d.SaldoAmortizacion, o => o.MapFrom(s => s.N_SALDO_AMORTIZACION))
            .ForMember(d => d.AbonoAmortizacion, o => o.MapFrom(s => s.N_ABONO_AMORTIZACION))
            .ForMember(d => d.SaldoMantenimiento, o => o.MapFrom(s => s.N_SALDO_MANTENIMIENTO))
            .ForMember(d => d.AbonoMantenimiento, o => o.MapFrom(s => s.N_ABONO_MANTENIMIENTO))
            .ForMember(d => d.SaldoInteres, o => o.MapFrom(s => s.N_SALDO_INTERES))
            .ForMember(d => d.AbonoInteres, o => o.MapFrom(s => s.N_ABONO_INTERES))
            .ForMember(d => d.Mora, o => o.MapFrom(s => s.N_MORA))
            .ForMember(d => d.AbonoMora, o => o.MapFrom(s => s.N_ABONO_MORA))
            .ForMember(d => d.MontoPago, o => o.MapFrom(s => s.N_MONTO_PAGO))
            .ForMember(d => d.MontoExhoneraMr, o => o.MapFrom(s => s.N_MONTO_EXHONERA_MR))
            .ForMember(d => d.Estatus, o => o.MapFrom(s => s.C_ESTATUS));
    }
}
