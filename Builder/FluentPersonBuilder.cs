using Builder.PersonModels;

namespace Builder
{
    public class FluentPersonBuilder
    {
        private readonly Person _person = new Person();

        public FluentPersonBuilder Called(string name)
        {
            _person.Name = name;
            return this;
        }

        public FluentPersonBuilder AtAge(int age)
        {
            _person.Age = age;
            return this;
        }

        public FluentPersonBuilder LivesAt(string street, string house)
        {
            _person.Address = new Address()
            {
                House = house,
                Street = street
            };
            return this;
        }

        public Person Build()
        {
            return _person;
        }
    }
}