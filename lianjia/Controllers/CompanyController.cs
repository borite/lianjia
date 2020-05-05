using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lianjia.Controllers
{
    
    [RoutePrefix("companyinfo")]

    public class CompanyController : ApiController
    {

        [Route("regCompany")]
        public IHttpActionResult RegisterCompany()
        {
            return Ok();

        }



    }
}
