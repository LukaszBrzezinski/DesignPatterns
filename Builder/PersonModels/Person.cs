namespace Builder.PersonModels
{
    public class Person
    {
        public string Name;
        public int Age;
        public Address Address;
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}, {nameof(Address)}: {Address}";
        }
    }
}