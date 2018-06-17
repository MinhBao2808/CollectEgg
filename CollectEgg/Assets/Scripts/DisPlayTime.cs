using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisPlayTime : MonoBehaviour {
	private Image fillImg;
	private float timeAmt = 10;
	private float timer;

	// Use this for initialization
	void Start () {
		fillImg = this.GetComponent<Image> ();
		timeAmt = TimeController.instance.Timer;
		timer = timeAmt;
	}

	// Update is called once per frame
	void Update () {
		if (timer > 0) {
			timer -= Time.deltaTime;
			fillImg.fillAmount = timer / timeAmt;
		} else {
			GameController.instance.IsGameOver ();
		}
	}


}
