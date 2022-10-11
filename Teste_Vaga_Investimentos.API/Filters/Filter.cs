using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Teste_Vaga_Investimentos.API.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute 
    {
        public ValidateModelAttribute(){}
        public override void OnActionExecuting(HttpActionContext actionExecutingContext)
        {
            Debug.WriteLine(string.Format("ModelState {0} executed at {1}", actionExecutingContext.ModelState, DateTime.Now.ToShortDateString()), "Web API Logs");
            Trace.WriteLine(string.Format("ModelState {0} executed at {1}", actionExecutingContext.ModelState, DateTime.Now.ToShortDateString()), "Web API Logs");
        }
    }
}