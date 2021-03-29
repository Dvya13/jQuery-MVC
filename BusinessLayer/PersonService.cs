using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public sealed class PersonService
    {
        private static readonly Lazy<PersonService> instance = new Lazy<PersonService>(() => new PersonService());

        public static PersonService GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        private PersonService() { }

        public List<Person> Persons { get; set; } = new List<Person>();
    }
}
