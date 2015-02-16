using UnityEngine;
using System.Collections;

public class GumballMachineController : MonoBehaviour {
	public GUIText display_text;
	private CoinController coin;
	private InspectorController inspector;

	void OnTriggerEnter(Collider other) {
		coin = other.GetComponent<CoinController> ();
		other.gameObject.SetActive (false);
		SetDisplayText ("Have Coin!");
		GameObject inspectorObject = GameObject.FindWithTag ("Inspector");
		if (inspectorObject == null) {
			Debug.Log ("object null!");
		}
		inspector = inspectorObject.GetComponent<InspectorController>();
	}

	void OnMouseDown() {
		SetDisplayText ("Crank turned!");


		inspector.GetCoin (coin);
	}

	void SetDisplayText(string s){
		display_text.text = s;
	}
}
