using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAPI.Middlewares
{
    public class LogFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Action method a girildi.");
        }
    }
}
