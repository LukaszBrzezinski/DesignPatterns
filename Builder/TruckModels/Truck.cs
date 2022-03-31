namespace Builder.TruckModels
{
    public class Truck
    {
        public string Driver;

        public SemiTrailer SemiTrailer;

        public Cargo Cargo;

        public static TruckBuilder New()
        {
            return new TruckBuilder();
        }

        public override string ToString()
        {
            return $"{nameof(Driver)}: {Driver}, {nameof(SemiTrailer)}: {SemiTrailer}, {nameof(Cargo)}: {Cargo}";
        }
    }
}
