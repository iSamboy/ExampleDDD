using ExampleDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Domain.Entities
{
    public class Person
    {
        // Person ID
        public Guid Id { get; init; }
        
        // Person name
        public PersonName Name { get; private set; }

        // ID creation assurance
        public Person(Guid id)
        {
            this.Id = id;
        }

        // Name assignment
        public void SetName(PersonName name)
        { 
                Name = name;
        }


    }
}
