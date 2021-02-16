using Microsoft.EntityFrameworkCore;
using QuickAzureDBApi.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickAzureDBApi.Repoitories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonDbContext personDbContext;

        public PersonRepository(PersonDbContext personDbContext)
        {
            this.personDbContext = personDbContext;
        }

        public async Task<List<Person>> GetAllPersonsAsync()
        {
            return await personDbContext.People.ToListAsync();
        }

        public Task<Person> GetPersonByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
