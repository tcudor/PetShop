using FluentValidation;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Validator
{
    public class AngajatValidator : AbstractValidator<Angajat>
    {
        public AngajatValidator()
        {
            RuleFor(x => x.Nume).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length < 2)
                {
                    context.AddFailure("Numele trebuie sa contina minim 2 caractere");
                }
                if (!list.All(char.IsLetter))
                {
                    context.AddFailure("Numele trebuie sa contine doar litere");
                }
            });
            RuleFor(x => x.Prenume).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length < 2)
                {
                    context.AddFailure("Prenumele trebuie sa contina minim 2 caractere");
                }
                if (!list.All(char.IsLetter))
                {
                    context.AddFailure("Prenumele trebuie sa contine doar litere");
                }
            });
            RuleFor(x => x.Adresa).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length < 10)
                {
                    context.AddFailure("Adresa trebuie sa contina minim 10 caractere");
                }
            });
            RuleFor(x => x.Telefon).Cascade(CascadeMode.Stop).Custom((list, context) =>
            {
                if (list.Length != 10)
                {
                    context.AddFailure("Numarul de Telefon trebuie sa contina 10 caractere");
                }
                if (!list.All(char.IsDigit))
                {
                    context.AddFailure("Numarul de Telefon trebuie sa contina doar cifre ");
                }
            });
            RuleFor(x => x.Email).EmailAddress().WithMessage("Introduceti o adresa de email valida");
            RuleFor(x => x.Sex).NotEmpty().WithMessage("Nu ati selectat sexul"); 
        }
    }
}
