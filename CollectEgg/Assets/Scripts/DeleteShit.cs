using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteShit : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Ground") {
			Destroy (gameObject);
			GameController.instance.removeEggsOnScence ();
		}
		if (other.gameObject.tag == "Fox") {
			GameController.instance.DeletePoint ();
			Destroy (gameObject);
			GameController.instance.removeEggsOnScence ();
		}
	}

//	IEnumerator delay() {
//		//		anim.SetBool() = false;
//		yield return new WaitForSeconds (0.5f);
//		Destroy (gameObject);
//		GameController.instance.removeEggsOnScence ();
//	}
}
