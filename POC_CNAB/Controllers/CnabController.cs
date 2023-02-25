using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace POC_CNAB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CnabController : ControllerBase
    {
        // GET: api/<CnabController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CnabController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CnabController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // POST api/<CnabController>
        [HttpPost]
        public async Task<IActionResult> ImportCnabFile(IFormFile file)
        {
            if (file.Length <= 0) return BadRequest("Arquivo Vazio");



            var result = new StringBuilder();

            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0) result.AppendLine(reader.ReadLine());
            }

            var teste = result.ToString();

            return Ok("Importado com Sucesso");
        }

        // PUT api/<CnabController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CnabController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
