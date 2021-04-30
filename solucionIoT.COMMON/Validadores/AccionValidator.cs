using FluentValidation;
using solucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace solucionIoT.COMMON.Validadores
{
     public class AccionValidator:GenericValidator<Accion>
    {
        public AccionValidator()
        {
            RuleFor(a => a.Actuador).NotEmpty().NotNull();
            RuleFor(a => a.IdDispositivo).NotNull().NotEmpty();
            RuleFor(a => a.Estado).NotNull().NotEmpty();
        }
    }
}
