using FluentValidation;
using solucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace solucionIoT.COMMON.Validadores
{
    public class UsuarioValidator:GenericValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.Correo).NotNull().NotEmpty().EmailAddress();
            RuleFor(u => u.Password).NotNull().NotEmpty().Length(5,50);
            RuleFor(u => u.Nombre).NotNull().NotEmpty().MinimumLength(10);
        }
    }
}
