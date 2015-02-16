using UnityEngine;
using System.Collections;

public class GumballController : MonoBehaviour {
	protected string color;
	
	protected void HideRenderer() {
		renderer.enabled = false;
	}
	public void ShowRenderer() {
		renderer.enabled = true;
	}

}
