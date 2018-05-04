using System;
using StudyStrategyPattern.CarBeep;
using StudyStrategyPattern.CarFuel;

namespace StudyStrategyPattern.Cars{

	public abstract class Car {

		protected IBeepable carBeepBehaviour;
		protected IUseFuel carFuelBehaviour;

		public Car () {
			carBeepBehaviour = new NormalBeep ();
			carFuelBehaviour = new CarUseFuel ();
		}

		public void SetCarBeepBehaviour (IBeepable newCarBeep) {
			carBeepBehaviour = newCarBeep;
		}

		public void SetCarFuelBehaviour (IUseFuel newCarFuel) {
			carFuelBehaviour = newCarFuel;
		}

		public virtual void Drive () {
			Console.WriteLine ("Drrrrrrrrr");
		}

		public void Beep () {
			carBeepBehaviour.Beep ();
		}

		public void UseFuel () {
			carFuelBehaviour.UseFuel ();
		}

		public abstract void ShowInfo ();
	}
}
