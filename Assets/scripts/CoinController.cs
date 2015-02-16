using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
	public float speed = 50;
	public string type = "123";
	void OnMouseDrag() {
		float moveHorizontal = Input.GetAxis("Mouse X");
		float moveVertical = Input.GetAxis("Mouse Y");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); 
		rigidbody.AddForce(movement * speed);
	}
}
