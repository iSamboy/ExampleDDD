using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Repositories;
using ExampleDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Infraestructure
{
    // Implementation of the Person repository interface

    public class PersonRepository : IPersonRepository
    {
        DataBaseContext dB;

        public PersonRepository(DataBaseContext dB_)
        {
            dB = dB_;
        }

        public async Task AddPerson(Person person)
        {
            await dB.AddAsync(person);
            await dB.SaveChangesAsync();
        }

        public async Task<Person> GetPersonByID(PersonId Id)
        {
            return await dB.Persons.FindAsync((Guid)Id); //Guid to ID convertion
        }
    }
}
