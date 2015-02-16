using UnityEngine;
using System.Collections;


public class InspectorController : MonoBehaviour {
	public GUIText display_text;
	private bool isRandom;

	void Start() {

		isRandom = false;
	}

	public void GetCoin(CoinController coin) {
		SetDisplayText("Inspector starts working...It's a " + coin.type) ;
		if (coin.type == "Quarter") {
			Debug.Log ("random value before pick:" + isRandom);
			getPicker ();

			if (isRandom){
				SetDisplayText("Random Picker picks the ball");
			}
			else{
				SetDisplayText("Green Picker picks the ball");
			}
			isRandom ^= true; // Toggle the random so the other picker is chosen next time

		}
	}

	void getPicker(){
		if (isRandom) {
			GameObject randomPickerObject = GameObject.FindWithTag ("RandomPicker");
			RandomPickerController randomPicker = randomPickerObject.GetComponent<RandomPickerController> ();
			randomPicker.releaseBall();

		} else {
			GameObject greenPickerObject = GameObject.FindWithTag ("GreenPicker");
			GreenPickerController greenPicker = greenPickerObject.GetComponent<GreenPickerController> ();
			greenPicker.releaseBall();
		}

		Debug.Log ("random value after pick:" + isRandom);
	}


	void SetDisplayText(string s){
		display_text.text = s;
	}


	bool getRandomValue(){
		int n = Random.Range(1, 3);
		if (n == 1) {
			return true;
		}
		else{
			return false;
		}
	}
}
