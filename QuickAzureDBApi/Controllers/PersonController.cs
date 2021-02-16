﻿using Microsoft.AspNetCore.Mvc;
using QuickAzureDBApi.Entities;
using QuickAzureDBApi.Repoitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace QuickAzureDBApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAllPeople()
        {
            return Ok(await personRepository.GetAllPersonsAsync());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}