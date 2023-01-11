using FluentValidation;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Validator
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Nume).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length < 2)
                {
                    context.AddFailure("Numele trebuie sa contina minim 2 caractere");
                }
                if (list.Any(char.IsDigit))
                {
                    context.AddFailure("Numele nu trebuie sa contina cifre");
                }
            });
            RuleFor(x => x.Prenume).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length < 2)
                {
                    context.AddFailure("Prenumele trebuie sa contina minim 2 caractere");
                }
                if (list.Any(char.IsDigit))
                {
                    context.AddFailure("Prenumele nu trebuie sa contina cifre");
                }
            });
            RuleFor(x => x.Adresa).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length < 10)
                {
                    context.AddFailure("Adresa trebuie sa contina minim 10 caractere");
                }
                if (list.Any(char.IsDigit))
                {
                    context.AddFailure("Adresa nu trebuie sa contina cifre");
                }
            });
            RuleFor(x => x.Telefon).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length != 10)
                {
                    context.AddFailure("Numarul de Telefon trebuie sa contina 10 caractere");
                }
                if (list.Any(char.IsLetter))
                {
                    context.AddFailure("Numarul de Telefon nu trebuie sa contina litere");
                }
            });
            RuleFor(x => x.Email).EmailAddress().WithMessage("Introduceti o adresa de email valida");
            RuleFor(x => x.Sex).NotEmpty().WithMessage("Nu ati selectat sexul"); ;
        }
    }
}
