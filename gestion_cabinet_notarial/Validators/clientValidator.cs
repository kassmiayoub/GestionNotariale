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
            RuleFor(c => c.Nom).NotEmpty().WithMessage("le champs Nom ne doit pas etre vide");
            RuleFor(c => c.Prenom).NotEmpty().WithMessage("le champs Prenom ne doit pas etre vide");
            RuleFor(c => c.Tele).NotEmpty().WithMessage("le champs Telephone ne doit pas etre vide");            
        }
    }
}
