﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiVesioning_3_1.V2.DTOs;

namespace WebApiVesioning_3_1.V2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
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
                    Id = Guid.NewGuid(),
                    Names = new List<string>() { "value1", "value2" }
                },
                new SampleResponse()
                {
                    Id = Guid.NewGuid(),
                    Names = new List<string>() { "value3", "value4" }
                }
            };
        }

        // GET api/<HelloWorldController>/5
        [HttpGet("{id}")]
        public SampleResponse Get(Guid id)
        {
            return new SampleResponse()
            {
                Id = id,
                Names = new List<string>() { "value1", "value2" }
            };
        }

        // POST api/<HelloWorldController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HelloWorldController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

        // DELETE api/<HelloWorldController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
