using Builder.TruckModels;
using System;

namespace Builder
{
    public class TruckBuilder
    {
        protected Truck Truck = new Truck();

        public TruckBuilder DrivenBy(string name)
        {
            Truck.Driver = name;
            return this;
        }

        public CargoBuilder Cargo() => new CargoBuilder(Truck);
        public SemiTrailerBuilder SemiTrailer() => new SemiTrailerBuilder(Truck);
        public Truck Build()
        {
            return Truck;
        }
    }

    public class SemiTrailerBuilder : TruckBuilder
    {
        public SemiTrailerBuilder(Truck truck)
        {
            Truck = truck;
        }

        public SemiTrailerBuilder Of(string semiTrailerName)
        {
            Truck.SemiTrailer ??= new SemiTrailer();
            Truck.SemiTrailer.Name = semiTrailerName;
            return this;
        }

        public SemiTrailerBuilder WithMaxLoadOf(int load)
        {
            Truck.SemiTrailer ??= new SemiTrailer();
            Truck.SemiTrailer.Capacity = load;
            return this;
        }
    }

    public class CargoBuilder : TruckBuilder
    {
        public CargoBuilder(Truck truck)
        {
            Truck = truck;
        }

        public CargoBuilder Of(string cargoName)
        {
            Truck.Cargo ??= new Cargo();
            Truck.Cargo.Name = cargoName;

            return this;
        }

        public CargoBuilder Weight(int load)
        {
            Truck.Cargo ??= new Cargo();

            if (Truck.SemiTrailer.Capacity < load)
            { 
                throw new ArgumentException($"Semitrailer is not available to carry load of {load}kg");
            }
            Truck.Cargo.Load = load;

            return this;
        }
    }
}
