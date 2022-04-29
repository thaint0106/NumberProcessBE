using MediatR;
using NumberProcessApplication.CommandHandlers;
using NumberProcessApplication.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NumberProcessApplication.Commamds
{
    public class NumberProcessingCommand : Command, IRequest<List<int>>
    {
        public NumberProcessingCommand()
        {
            AmountItem = 10;
        }
        //input value
        public string Input { get; set; }
        //amount item want to move
        public int AmountItem { get; set; }
        public override bool IsValid()
        {
            ValidationResult = new NumberProcessingValidator().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
