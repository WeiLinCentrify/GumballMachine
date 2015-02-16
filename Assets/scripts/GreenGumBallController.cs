using UnityEngine;
using System.Collections;

public class GreenGumBallController : GumballController {
	public GreenGumBallController(){
		color = "green";
	}


	void Start () {
		HideRenderer ();
		
	}
}
