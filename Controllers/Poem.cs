using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Renzorapi.Data.Services;
using Renzorapi.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Renzorapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoemsController : ControllerBase
    {
        public PoemService _poemService;
        public PoemsController(PoemService poemService)
        {
            _poemService = poemService;
        }


        [HttpPost("add-poems")]
        public IActionResult AddPoem([FromBody] PoemVm poem)
        {
            _poemService.AddPoem(poem);
            return Ok();
        }

        [HttpGet("get-all-poems")]
        public IActionResult GetAllPoems()
        {
        var allpoems= _poemService.GetAllPoem();
            return Ok( allpoems);
        }

        [HttpGet("get-poem-by-Id/{id}")]
        public IActionResult GetPoems(int id)
        {
            var poem = _poemService.GetPoemByID(id);
            return Ok(poem);
        }

        [HttpPut("update-poem-by-Id/{id}")]
        public IActionResult UpdatePoems(int id,[FromBody]PoemVm poemVm)
        {
            var poem = _poemService.UpdatePoem(id,poemVm);
            return Ok(poem);
        }


        [HttpDelete("delete-poem-by-Id/{id}")]
        public IActionResult DeletPoems(int id)
        {
             _poemService.DeletePoemById(id);
            return Ok();
        }
    }
}
