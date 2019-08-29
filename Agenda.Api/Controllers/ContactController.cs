using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public List<Contact> GetContacts()
        {
            return null;
        }
    }
}
