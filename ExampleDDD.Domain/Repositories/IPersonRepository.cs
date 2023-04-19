using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Domain.Repositories
{
    //Definition or declaration of necessary operations

    public interface IPersonRepository
    {
        Task<Person> GetPersonByID(PersonId Id);
        Task AddPerson(Person person);
    }
}
