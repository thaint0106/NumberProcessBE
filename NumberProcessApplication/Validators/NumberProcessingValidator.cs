using FluentValidation;
using NumberProcessApplication.Commamds;
using NumberProcessApplication.Extentions;
using System;
using System.Text.RegularExpressions;

namespace NumberProcessApplication.Validators
{
    public sealed class NumberProcessingValidator : AbstractValidator<NumberProcessingCommand>
    {
        public NumberProcessingValidator()
        {
            RuleFor(x => x.Input).Must(y => !y.MyEmpty()).WithMessage("Input is required");
            RuleFor(x => x.Input).Must(y => CheckFormat(y)).WithMessage("Value not match array format");
        }

        bool CheckFormat(string str)
        {
            var pattern = @"^-?[0-9]+(,-?[0-9]+)*$";
            Regex re = new Regex(pattern);
            return re.IsMatch(str);
        }

    }
}
