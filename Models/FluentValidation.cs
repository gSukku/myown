using System;
using FluentValidation;

namespace Sample.Models
{ 
    public class ValuesValidator : AbstractValidator<Values>  
    {  
        /// <summary>  
        /// Validator rules for Product  
        /// </summary>  
        public ValuesValidator()  
        {  
            //RuleFor(x => x.ti_type).GreaterThan(0).WithMessage("The Product ID must be at greather than 0.");  
  
            RuleFor(x => x.ti_type)  
                .NotEmpty()  
                .WithMessage("The ti_type Name cannot be blank..................");
                
  
          //  RuleFor(x => x.ti_bu_type)  
            //    .NotEmpty()  
              //  .WithMessage("The ti_bu_type Description must be at least 150 characters long.");  
  
           // RuleFor(x => x.ti_bu_code).GreaterThan(0).WithMessage("The Product Price must be at greather than 0.");  
        }  
    }  
}   