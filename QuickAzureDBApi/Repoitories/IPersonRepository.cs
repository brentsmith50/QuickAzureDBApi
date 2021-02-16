using QuickAzureDBApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickAzureDBApi.Repoitories
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllPersonsAsync();
        Task<Person> GetPersonByIdAsync();
    }
}
