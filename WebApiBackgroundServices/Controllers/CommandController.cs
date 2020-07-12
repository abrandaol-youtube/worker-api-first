using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBackgroundServices.Domain;
using WebApiBackgroundServices.Repository;

namespace WebApiBackgroundServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private ICommandRepository _commandRepository;

        public CommandController(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        [HttpPost]
        public IActionResult SetCommand([FromBody] Message message)
        {
            _commandRepository.SetMessage(message);

            return Ok(_commandRepository.GetMessage());
        }
    }
}
