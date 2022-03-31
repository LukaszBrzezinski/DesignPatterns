using Builder.PersonModels;

namespace Builder
{
    public class PersonBuilder
    {
        private readonly Person _person = new Person();

        public void Called(string name)
        {
            _person.Name = name;
        }

        public void AtAge(int age)
        {
            _person.Age = age;
        }

        public void LivesAt(string street, string house)
        {
            _person.Address = new Address()
            {
                House = house,
                Street = street
            };
        }

        public Person Build()
        {
            return _person;
        }
    }
}