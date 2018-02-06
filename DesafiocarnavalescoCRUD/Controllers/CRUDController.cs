using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafiocarnavalescoCRUD.Controllers
{
    [Produces("application/json")]
    [Route("api/CRUD")]
    public class CRUDController : Controller
    {
	    [HttpGet, Route("read")]
	    public async Task<IActionResult> Read()
	    {
		    try
		    {
			    string[] lines = System.IO.File.ReadAllLines(@"C:\Users\fmota\Desktop\teste\testando.txt");
			    return Accepted(lines);
		    }
		    catch (Exception e)
		    {
			    return new StatusCodeResult(500);
		    }
	    }
    }
}