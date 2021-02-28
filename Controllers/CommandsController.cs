using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commandoo;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDTO>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(commandItems));
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <CommandReadDTO> GetCommandById(int Id)
        {
            var commandItem = _repository.GetCommandById(Id);
            if(commandItem!=null){
                return Ok(_mapper.Map<CommandReadDTO>(commandItem));
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}