namespace Builder.CarModels
{
    public class Car
    {
        public int HorsePower;
        public Brakes Brakes;

        public static ISpecifyEngine New()
        {
            return CarBuilder.Create();
        }

        public override string ToString()
        {
            return $"{nameof(HorsePower)}: {HorsePower}, {nameof(Brakes)}: {Brakes}";
        }
    }

}
