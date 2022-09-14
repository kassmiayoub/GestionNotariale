using FluentValidation;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cabinet_notarial.Validators
{
    public class fichier_client_validator : AbstractValidator<fichiers_client>
    {
        public fichier_client_validator()
        {
            RuleFor(c => c.titre).NotEmpty().WithMessage("le champs adresse ne doit pas etre vide");
            RuleFor(c => c.path).NotEmpty().WithMessage("le champs Nom ne doit pas etre vide");
        }
    }
}
