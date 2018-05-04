using System;
using System.Collections.Generic;
using StudyStrategyPattern.Cars;
using StudyStrategyPattern.CarFuel;
using StudyStrategyPattern.CarBeep;

namespace StudyStrategyPattern{

	class Program {

		private static List<Car> allCars = new List<Car> ();

		static void Main (string[] args) {
			//Create and show all possible cars
			AddCars ();
			ShowCars ();

			//Create car to upgrade
			Car upgradableCar = new SimpleCar ();

			Console.WriteLine ("Car before upgrade: ");
			ShowCarInfo (upgradableCar);

			upgradableCar.SetCarFuelBehaviour (new CarNotUseFuel ());
			upgradableCar.SetCarBeepBehaviour (new NotNormalBeep ());

			Console.WriteLine ("Car after upgrade: ");
			ShowCarInfo (upgradableCar);

			Console.ReadKey ();
		}

		private static void AddCars () {
			allCars.Add (new SimpleCar ());
			allCars.Add (new ElectroCar ());
			allCars.Add (new ChildrenCar ());
		}

		private static void ShowCars () {
			for (int i = 0; i < allCars.Count; i++) {
				ShowCarInfo (allCars[i]);
				Console.WriteLine ();
			}
		}

		private static void ShowCarInfo (Car car) {
			car.ShowInfo ();
			car.Drive ();
			car.UseFuel ();
			car.Beep ();
		}
	}
}
