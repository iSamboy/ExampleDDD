using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Domain.ValueObjects
{
    // Name creation and initialization

    public record PersonName
    {
        public string Value { get; init; }

        internal PersonName(string value)
        {
            this.Value = value;  
        }

        public static PersonName Create(string value)
        {
            validate(value);
            return new PersonName(value);
        }

        // Name validation
        private static void validate(string value)
        {
            if (value == null)
                throw new ArgumentNullException("value can't be null");
        }
    }
}
