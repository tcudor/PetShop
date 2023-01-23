using FluentValidation;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Validator
{
    public class AnimalValidator:AbstractValidator<Animal>
    {
        public AnimalValidator()
        {
            RuleFor(x => x.Categorie).NotEmpty().WithMessage("Nu ati selectat categoria");
            RuleFor(x => x.Rasa).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length < 2)
                {
                    context.AddFailure("Rasa trebuie sa contina minim 2 caractere");
                }
                if (list.All(char.IsLetter))
                {
                    context.AddFailure("Rasa nu trebuie sa contina doar litere");
                }
            });
            RuleFor(x => x.Descriere).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length < 10)
                {
                    context.AddFailure("Descrierea trebuie sa contina minim 10 caractere");
                }
            });
            RuleFor(x => x.Sex).NotEmpty().WithMessage("Nu ati selectat sexul");
        }
    }
}
