using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SharpTrooper.API.Filters
{
    public class QueryParamFilterAttribute : ActionFilterAttribute
    {
        private readonly string _paramName;

        public QueryParamFilterAttribute(string paramName)
        {
            _paramName = paramName;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Query.TryGetValue(_paramName, out var paramValue))
            {
                context.ActionArguments[_paramName] = paramValue.ToString();
            }

            base.OnActionExecuting(context);
        }
    }

}
