using System;
using StudyStrategyPattern.CarBeep;
using StudyStrategyPattern.CarFuel;

namespace StudyStrategyPattern.Cars {

	public class ChildrenCar : Car {

		public ChildrenCar () {
			carBeepBehaviour = new NotNormalBeep ();
			carFuelBehaviour = new CarNotUseFuel ();
		}

		public override void ShowInfo () {
			Console.WriteLine ("This is children car.");
		}
	}

}
