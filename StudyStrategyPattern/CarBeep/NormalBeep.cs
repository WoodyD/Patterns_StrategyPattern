using System;

namespace StudyStrategyPattern.CarBeep {

	public class NormalBeep : IBeepable {

		public void Beep () {
			Console.WriteLine ("Beep! Beep!");
		}
	}
}
