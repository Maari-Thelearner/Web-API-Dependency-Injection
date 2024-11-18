using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CompanyService;

namespace WEBAPI_DEPENDENCY_INJECTION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyInfoForScoped _companyInfoForScopedService;
        private readonly ICompanyInfoForSingleton _companyInfoForSingletonService;
        private readonly ICompanyInfoForTransient _companyInfoForTransientService1;
        private readonly ICompanyInfoForTransient _companyInfoForTransientService2;
        public CompanyController(ICompanyInfoForScoped companyInfoForScoped, ICompanyInfoForSingleton companyInfoForSingleton, ICompanyInfoForTransient companyInfoForTransient1, ICompanyInfoForTransient companyInfoForTransient2)
        {
            this._companyInfoForScopedService = companyInfoForScoped;
            this._companyInfoForSingletonService = companyInfoForSingleton;
            this._companyInfoForTransientService1 = companyInfoForTransient1;
            this._companyInfoForTransientService2 = companyInfoForTransient2;
        }

        
        // A singleton service is created once for the entire lifetime of the application.
        [HttpGet, Route("SingletonActionMethod")]
        public IActionResult SingletonActionMethod()
        {
            return Ok(_companyInfoForSingletonService);
        }


        // A Scoped Service is created once per request of API call.
        [HttpGet, Route("ScopedActionMethod")]
        public IActionResult ScopedActionMethod()
        {
            return Ok(_companyInfoForScopedService);
        }


        // A Transient service is created every time its called.
        [HttpGet, Route("TransientActionMethod")]
        public IActionResult TransientActionMethod()
        {
            return Ok(_companyInfoForTransientService1.GetNumber() + "\n" + _companyInfoForTransientService2.GetNumber());
        }
    }
}
