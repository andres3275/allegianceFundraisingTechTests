using System.Collections.Generic;
using System.Threading.Tasks;
using customerRelationshipApi.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace customerRelationshipApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private static readonly Contact[] contacts =
        {
            new Contact()
            {
                Salutation="Mr.",
                FirstName="Paul",
                LastName="Mitchell",
                AddressLine1="1222 56th St S",
                AddressLine2="apt 23",
                City="Fargo",
                State="ND",
                ZipCode="58104",
                EmailAddress="ash@sample.com",
                TelePhoneNumber="5551345699"
            }
        };

        public ContactController()
        {
        }

        [HttpGet]
        public async Task<IEnumerable<Contact>> Get()
        {
            return await Task.FromResult<IEnumerable<Contact>>(contacts);
        }
    }
}
