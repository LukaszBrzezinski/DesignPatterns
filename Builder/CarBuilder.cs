using Builder.CarModels;
using System;

namespace Builder
{
    public interface ISpecifyEngine
    {
        ISpecifyBrakes WithEngine(int hp);
    }

    public interface ISpecifyBrakes
    {
        ICarBuilder WithBrakes(Brakes brakes);
    }

    public interface ICarBuilder
    {
        Car Build();
    }

    public class CarBuilder : ISpecifyEngine, ISpecifyBrakes, ICarBuilder
    {
        private readonly Car _car = new Car();
        private CarBuilder()
        {

        }
        public static ISpecifyEngine Create()
        {
            return new CarBuilder();
        }

        public ISpecifyBrakes WithEngine(int hp)
        {
            _car.HorsePower = hp;
            return this;
        }

        public ICarBuilder WithBrakes(Brakes brakes)
        {
            var horsePowers = _car.HorsePower;
            switch (brakes)
            {
                case Brakes.Eco when horsePowers > 100:
                case Brakes.Standard when horsePowers > 150:
                    throw new ArgumentException($"Wrong brakes for {horsePowers}HP engine");
            }

            _car.Brakes = brakes;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
