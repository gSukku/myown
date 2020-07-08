using System.Collections.Generic;
using System.Linq;  
using System.Net;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Sample.Models
{
    public class ValidateModelAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new System.NotImplementedException();
        }


        public void OnActionExecuting(ActionExecutingContext actionContext)
        {
           if (actionContext.ModelState.IsValid == false)
            {
               
            }
        }
    }
}