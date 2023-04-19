using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Repositories;
using ExampleDDD.Domain.ValueObjects;

namespace ExampleDDD.API.Queries
{
    // To obtain the information

    public class PersonQueries
    {
        private readonly IPersonRepository personRepository;

        public PersonQueries(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        // To ensure the correct creation of the person ID

        public async Task<Person> GetPersonIdAsync(Guid id)
        {
            var response = await personRepository.GetPersonByID(
                PersonId.create(id));
            return response;
        }

    }
}
