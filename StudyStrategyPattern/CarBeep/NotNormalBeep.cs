using System;

namespace StudyStrategyPattern.CarBeep {

	public class NotNormalBeep : IBeepable {

		public void Beep () {
			Console.WriteLine ("Beep, Beep, Motherfucker!");
		}

	}
}
