using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o=>o.Brand).MinimumLength(2);
            RuleFor(o=>o.Brand).NotEmpty();
            RuleFor(o=>o.Model).Must(a).WithMessage("Model ismi A harfi ile başlamalı!");
            


        }

        private bool a(string arg){
            return arg.StartsWith("A");
        }
    }
}