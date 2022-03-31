namespace Builder.PersonModels
{
    public class Address
    {
        public string Street;
        public string House;

        public override string ToString()
        {
            return $"{nameof(Street)}: {Street}, {nameof(House)}: {House}";
        }
    }
}