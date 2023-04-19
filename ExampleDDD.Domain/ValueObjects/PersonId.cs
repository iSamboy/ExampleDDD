using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Domain.ValueObjects
{
    // ID creation and initialization

    public record PersonId
    {
        public Guid value { get; init; }

        internal  PersonId(Guid value_)
        {
            value = value_;
        }

        public static PersonId create(Guid value)
        {
            return new PersonId(value);
        }

        // Person ID convertion to Guid
        public static implicit operator Guid(PersonId personId)
        {
            return personId.value;
        }
    }
}
