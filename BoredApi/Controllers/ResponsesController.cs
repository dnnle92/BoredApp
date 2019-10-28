using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoredApi.Data;
using BoredDTO;
using BoredApi.Data.EFCore;

namespace BoredApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsesController : BoredDbController<Response, EFCoreResponseRepository>
    {
        public ResponsesController(EFCoreResponseRepository repository) : base(repository)
        {

        }
    }
}
