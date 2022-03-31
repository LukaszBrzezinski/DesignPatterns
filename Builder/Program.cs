using Builder.CarModels;
using Builder.TruckModels;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal builder
            var personBuilder = new PersonBuilder();

            personBuilder.Called("Adam");
            personBuilder.AtAge(10);
            personBuilder.LivesAt("Some street", "10/2");

            var person1 = personBuilder.Build();

            Console.WriteLine(person1);

            // Fluent builder
            var fluentPersonBuilder = new FluentPersonBuilder();

            var person2 = fluentPersonBuilder
                .Called("Adam")
                .AtAge(10)
                .LivesAt("Some street", "10/2")
                .Build();

            Console.WriteLine(person2);

            // Stepwise builder
            var car = CarBuilder.Create()
                .WithEngine(100)
                .WithBrakes(Brakes.Eco)
                .Build();

            Console.WriteLine(car);

            // even better readability
            var car2 = Car.New()
                .WithEngine(100)
                .WithBrakes(Brakes.Sport)
                .Build();

            Console.WriteLine(car2);

            // facade builder 
            var truck = Truck.New()
                .DrivenBy("Adam Smith")
                .SemiTrailer()
                    .Of("Volvo")
                    .WithMaxLoadOf(1234)
                .Cargo()
                    .Of("Sand")
                    .Weight(1234)
                .Build();

            Console.WriteLine(truck);
        }
    }
}
