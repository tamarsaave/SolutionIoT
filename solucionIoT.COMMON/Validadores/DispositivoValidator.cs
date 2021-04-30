using FluentValidation;
using solucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace solucionIoT.COMMON.Validadores
{
    public class DispositivoValidator:GenericValidator<Dispositivo>
    {
        public DispositivoValidator()
        {
            RuleFor(d => d.IdUsuario).NotNull().NotEmpty();
            RuleFor(d => d.Ubicacion).NotEmpty().NotNull().Length(3, 50);
            RuleFor(d => d.UsoRelevador1).NotNull().NotEmpty().Length(3,50);
            RuleFor(d => d.UsoRelevador2).NotNull().NotEmpty().Length(3, 50);
            RuleFor(d => d.UsoRelevador3).NotNull().NotEmpty().Length(3, 50);
            RuleFor(d => d.UsoRelevador4).NotNull().NotEmpty().Length(3, 50);
            RuleFor(d => d.UsoBuzzer).NotNull().NotEmpty().Length(3, 50);
            RuleFor(d => d.UbicacionPIR).NotNull().NotEmpty().Length(3, 50);
        }
    }
}
