using System;

namespace ExampleClassBaseDerived
{
	internal class ClassBaseVehicle
	{
		public string Manufacturer { get; set; } = default;
		public string Model { get; set; } = default;
		public DateTime DateManufacturer { get; set; } = default;
		public int Weight { get; set; } = default;
		public int Cost { get; set; } = default;

		public void PrintInfo1()
		{
			Console.WriteLine(@"ClassBaseVehicle.PrintInfo1()");
		}

		public virtual void PrintInfo2()
		{
			Console.WriteLine(@"ClassBaseVehicle.PrintInfo2()");
		}

		public new void PrintInfo3()
		{
			Console.WriteLine(@"ClassBaseVehicle.PrintInfo3()");
		}
	}
}
