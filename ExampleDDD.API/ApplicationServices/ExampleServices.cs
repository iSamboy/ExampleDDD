using ExampleDDD.API.Comands;
using ExampleDDD.API.Queries;
using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Repositories;
using ExampleDDD.Domain.ValueObjects;

namespace ExampleDDD.API.ApplicationServices
{
    public class ExampleServices
    {
        private readonly IPersonRepository repository;
        private readonly PersonQueries personQueries;

        public ExampleServices(IPersonRepository repository,
            PersonQueries personQueries

            )
        {
            this.repository = repository;
            this.personQueries = personQueries;
        }

        // To ensure the correct creation or entry of the person
        public async Task HandlerComand(CreatePersonComand createPerson)
        {
            var person = new Person(
                PersonId.create(createPerson.personId)
                );
            person.SetName(PersonName.Create(createPerson.Name));
            await repository.AddPerson(person);
        }

        public async Task<Person> GetPerson(Guid id)
        {
            return await personQueries.GetPersonIdAsync(id);
        }
    }
}
