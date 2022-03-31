namespace Builder.TruckModels
{
    public class SemiTrailer
    {
        public string Name;
        public int Capacity;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Capacity)}: {Capacity}";
        }
    }
}