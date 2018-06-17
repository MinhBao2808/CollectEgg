using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour {
	public static TimeController instance = null;
	private int timer;

	void Awake () {
		if (instance == null) {
			instance = this;
		}
		timer = PlayerPrefs.GetInt ("timeToEnd", timer);
		Debug.Log (timer);
	}

	public float Timer {
		get { return timer; }
	}
}
