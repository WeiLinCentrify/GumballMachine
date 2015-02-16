using UnityEngine;
using System.Collections;

public class RandomPickerController : PickerController {
	public override void releaseBall() {
		showGumball (getRandomColor());
	}

	string getRandomColor(){
		int n = Random.Range(1, 4);
		if (n == 1) {
			return "Red";
		} else if (n == 2) {
			return "Blue";
		} else {
			return "Green1";
		}
	}
}
