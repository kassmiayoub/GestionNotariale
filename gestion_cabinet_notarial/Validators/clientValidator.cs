using FluentValidation;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cabinet_notarial.Validators
{
    public class clientValidator : AbstractValidator<client>
    {
        public clientValidator()
        {
            RuleFor(c => c.adress).NotEmpty().WithMessage("le champs adresse ne doit pas etre vide");
        }
    }
}
