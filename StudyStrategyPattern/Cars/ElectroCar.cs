using System;
using StudyStrategyPattern.CarFuel;

namespace StudyStrategyPattern.Cars {
	public class ElectroCar : Car {

		public ElectroCar () {
			carFuelBehaviour = new CarNotUseFuel ();
		}

		public override void Drive () {
			Console.WriteLine ("Shhhhhhhhhhhh");
		}

		public override void ShowInfo () {
			Console.WriteLine ("This is electro car.");
		}
	}
}
