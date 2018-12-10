using System;

namespace ExampleClassBaseDerived
{
	internal class ClassDerivedCar : ClassBaseVehicle
	{
		public double Lat { get; set; } = default;
		public double Lon { get; set; } = default;

		public new void PrintInfo1()
		{
			Console.WriteLine(@"ClassDerivedCar.PrintInfo1()");
		}

		public override void PrintInfo2()
		{
			Console.WriteLine(@"ClassDerivedCar.PrintInfo2()");
		}

		public new void PrintInfo3()
		{
			Console.WriteLine(@"ClassDerivedCar.PrintInfo3()");
		}
	}
}
