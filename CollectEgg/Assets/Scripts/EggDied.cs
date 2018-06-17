using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggDied : MonoBehaviour {
	private Animator anim;
//	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();
	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Ground") {
			Destroy (gameObject);
			GameController.instance.removeEggsOnScence ();
		}
		if (other.gameObject.tag == "Fox") {
			GameController.instance.CaculatePoint ();
			Destroy (gameObject);
			GameController.instance.removeEggsOnScence ();
		}
	}

//	IEnumerator delay() {
////		anim.SetBool() = false;
//		anim.Play("EggBroken");
//		yield return new WaitForSeconds (0.5f);
//		Destroy (gameObject);
//		GameController.instance.removeEggsOnScence ();
//	}
}
