using System;

namespace ExampleClassBaseDerived
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine(@"----------------------------------------------------------------------");
			Console.WriteLine(@"---             Examples of base and derived classes.              ---");
			Console.WriteLine(@"----------------------------------------------------------------------");
			Console.WriteLine();

			ClassDerivedCar carNissanAlmera = new ClassDerivedCar() {
				Manufacturer = "Nissan",
				Model = "Almera",
				DateManufacturer = default,
				Cost = 100_000,
				Weight = 2_000,
				Lat = 10.0,
				Lon = 20.0,
			};
			Console.WriteLine(@"ClassDerivedCar carNissanAlmera = new ClassDerivedCar() {...};");
			Console.Write(@"carNissanAlmera.PrintInfo1(): ");
			carNissanAlmera.PrintInfo1();
			Console.Write(@"carNissanAlmera.PrintInfo2(): ");
			carNissanAlmera.PrintInfo2();
			Console.Write(@"carNissanAlmera.PrintInfo3(): ");
			carNissanAlmera.PrintInfo3();
			Console.WriteLine();

			ClassBaseVehicle vehicle = carNissanAlmera;
			Console.WriteLine(@"ClassBaseVehicle vehicle = carNissanAlmera;");
			Console.WriteLine($@"vehicle == carNissanAlmera: {Convert.ToString(vehicle == carNissanAlmera)}");
			Console.WriteLine($@"vehicle.Manufacturer: {vehicle.Manufacturer}");
			Console.WriteLine($@"vehicle.Model: {vehicle.Model}");
			Console.WriteLine($@"vehicle.Cost: {vehicle.Cost}");
			Console.WriteLine($@"vehicle.Model: {vehicle.Weight}");
			Console.WriteLine($@"vehicle.Lat: <error>");
			Console.WriteLine($@"vehicle.Lon: <error>");
			Console.WriteLine($@"carNissanAlmera.Lat: {carNissanAlmera.Lat}");
			Console.WriteLine($@"carNissanAlmera.Lon: {carNissanAlmera.Lon}");
			Console.Write(@"vehicle.PrintInfo1(): ");
			vehicle.PrintInfo1();
			Console.Write(@"vehicle.PrintInfo2(): ");
			vehicle.PrintInfo2();
			Console.Write(@"vehicle.PrintInfo3(): ");
			vehicle.PrintInfo3();
			Console.WriteLine();

			ClassDerivedCar carSalled = (ClassDerivedCar)vehicle;
			Console.WriteLine(@"ClassDerivedCar carSalled = (ClassDerivedCar)vehicle;");
			Console.WriteLine($@"carSalled.Lat: {carSalled.Lat}");
			Console.WriteLine($@"carSalled.Lon: {carSalled.Lon}");
			Console.WriteLine();


			Console.WriteLine(@"Press Enter to close.");
			Console.ReadLine();
		}
	}
}
