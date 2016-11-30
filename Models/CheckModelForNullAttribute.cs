
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Inventory.Models
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class CheckModelForNullAttribute : ActionFilterAttribute
    {
        private readonly Func<Dictionary<string, object>, bool> _validate;

        public CheckModelForNullAttribute() : this(arguments => arguments.ContainsValue(null))
        { }

        public CheckModelForNullAttribute(Func<Dictionary<string, object>, bool> checkCondition)
        {
            _validate = checkCondition;
        }

        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            // if (_validate(actionContext.ActionArguments))
            // {
                
            //     //actionContext.Result = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "The argument cannot be null");
            // }
        }
    }
}