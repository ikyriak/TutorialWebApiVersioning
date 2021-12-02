using Microsoft.AspNetCore.Mvc;
using WebApiVesioning_6_0.V1.DTOs;

namespace WebApiVesioning_6_0.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        // GET: api/<HelloWorldController>
        [HttpGet]
        public IEnumerable<SampleResponse> Get()
        {
            return new List<SampleResponse>(){
                new SampleResponse()
                {
                    Id = 1,
                    Name = "value1"
                },
                new SampleResponse()
                {
                    Id = 2,
                    Name = "value2"
                }
            };
        }

        // GET api/<HelloWorldController>/5
        [HttpGet("{id}")]
        public SampleResponse Get(int id)
        {
            return new SampleResponse()
            {
                Id = id,
                Name = "value3"
            };
        }

        // POST api/<HelloWorldController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HelloWorldController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HelloWorldController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
