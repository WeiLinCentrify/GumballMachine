using UnityEngine;
using System.Collections;

public class PickerController : MonoBehaviour {

	public virtual void releaseBall () {}

	protected void showGumball(string tag) {
		GameObject gumballObject = GameObject.FindWithTag (tag);
		if (gumballObject == null) {
			Debug.Log ("object null!");
		}
		GumballController gumball = gumballObject.GetComponent<GumballController> ();
		gumball.ShowRenderer(); //show gumball on the screen

		Rigidbody gumballRigidBody = gumballObject.AddComponent<Rigidbody>(); // Add the rigidbody.
		gumball.rigidbody.mass = 5;
		gumball.rigidbody.useGravity = true;
	}
}
