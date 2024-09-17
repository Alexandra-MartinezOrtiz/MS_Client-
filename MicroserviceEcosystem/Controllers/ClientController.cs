using MicroserviceEcosystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceEcosystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClientController : Controller
    {
        [HttpGet("client")]
        public async Task<Client> CreateClient()
        {
            Client clienteGet = new Client();
            clienteGet.MiddleName = "Juan";
            clienteGet.FirstName = "Pablo";
            clienteGet.LastName = "Ortiz";
            clienteGet.Phone = 0981104568;
            clienteGet.SecondSurname = "Perez";
            clienteGet.Address = "av juan perez";
            clienteGet.CreatedAt = DateTime.UtcNow;
            clienteGet.UpdatedAt = DateTime.UtcNow;

            return clienteGet;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
