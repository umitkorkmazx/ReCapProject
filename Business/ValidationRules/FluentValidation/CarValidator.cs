using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(2).WithMessage(Messages.CarNameInValid);
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage(Messages.UnitPriceInvalid);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(3500).When(c => c.BrandId == 7);
        }
    }
}
