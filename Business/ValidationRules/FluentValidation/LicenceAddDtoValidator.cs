﻿using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class LicenceAddDtoValidator : AbstractValidator<LicenceAddDto>
    {
        public LicenceAddDtoValidator()
        {
            RuleFor(c => c.PersonTypeId).GreaterThan(0);
            RuleFor(c => c.CityId).GreaterThan(0);
            RuleFor(c => c.UserId).GreaterThan(0);
            RuleFor(c => c.BillAddress).MinimumLength(15);
            RuleFor(c => c.WebSite).MinimumLength(10);
            RuleFor(c => c.PhoneNumber).Must(CheckPhoneNumber);
            RuleFor(c => c.ProfilName).MinimumLength(5);
            RuleFor(c => c.TaxNo).MinimumLength(3);
            RuleFor(c => c.TaxOffice).MinimumLength(3);
            RuleFor(c => c.Email).EmailAddress();
        }

        public bool CheckPhoneNumber(string arg)
        {

            return Regex.IsMatch(arg, @"^((\d{11}))$", RegexOptions.IgnoreCase);

        }
    }
}
