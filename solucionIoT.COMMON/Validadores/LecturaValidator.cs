using FluentValidation;
using solucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace solucionIoT.COMMON.Validadores
{
    public class LecturaValidator: GenericValidator<Lectura>
    {
        public LecturaValidator()
        {
            RuleFor(l => l.Temperatura).NotNull().NotEmpty();
            RuleFor(l => l.Humedad).NotNull().NotEmpty();
            RuleFor(l => l.Luminosidad).NotNull().NotEmpty();
            RuleFor(l => l.IdDispositivo).NotNull().NotEmpty();
        }
    }
}
