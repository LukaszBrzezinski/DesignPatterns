namespace Builder.TruckModels
{
    public class Cargo
    {
        public string Name;
        public int Load;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Load)}: {Load}";
        }
    }
}