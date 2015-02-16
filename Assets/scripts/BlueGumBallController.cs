using UnityEngine;
using System.Collections;

public class BlueGumBallController : GumballController {
	public BlueGumBallController(){
		color = "blue";
	}

	
	void Start () {
		HideRenderer ();
		
	}
}
