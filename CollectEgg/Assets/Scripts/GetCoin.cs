using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour {

	private Animator anim;
	//	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Ground") {
			Destroy (gameObject);
			GameController.instance.removeEggsOnScence ();
		}
		if (other.gameObject.tag == "Fox") {
			GameController.instance.CaculateCoin ();
			Destroy (gameObject);
			GameController.instance.removeEggsOnScence ();
		}
	}
}
