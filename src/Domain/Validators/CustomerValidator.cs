using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validators;

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(p => p.Name).NotEmpty().MinimumLength(3);
        RuleFor(p => p.Email).EmailAddress();

    }
}

public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator()
    {
        RuleFor(p => p.City).NotEmpty();
    }
}
