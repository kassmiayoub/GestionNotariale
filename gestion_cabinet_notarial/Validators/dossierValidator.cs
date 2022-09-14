using FluentValidation;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cabinet_notarial.Validators
{
    public class dossierValidator : AbstractValidator<dossier>
    {
        public dossierValidator()
        {
            RuleFor(c => c.Numdossier).NotEmpty().WithMessage("le champs Numdossier ne doit pas etre vide");
            RuleFor(c => c.PRIX_ACQUISITION).NotEmpty().WithMessage("le champs PRIX_ACQUISITION ne doit pas etre vide");
            RuleFor(c => c.Titrefoncier).NotEmpty().WithMessage("le champs Titrefoncier ne doit pas etre vide");
            RuleFor(c => c.dateouverture).NotEmpty().WithMessage("le champs Date Ouverture ne doit pas etre vide");
            RuleFor(c => c.Objet).NotEmpty().WithMessage("le champs Objet ne doit pas etre vide");
        }
    }
}
