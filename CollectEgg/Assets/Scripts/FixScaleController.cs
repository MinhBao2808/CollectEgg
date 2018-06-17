using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixScaleController : MonoBehaviour {
	public static FixScaleController instance;
	[SerializeField] private GameObject maxLeftX;
	[SerializeField] private GameObject maxRightX;
	[SerializeField] private GameObject[] chicken;
	private float leftX;
	private float rightX;

	void Awake () {
		if (instance == null) { 
			instance = this;
			leftX = maxLeftX.transform.position.x;
			rightX = maxRightX.transform.position.x;
			Vector3 tempLeft = maxLeftX.transform.position;
			Vector3 tempRight = maxRightX.transform.position;
			float tempMiddelLeft = tempLeft.x / 2f;
			float tempMiddelRight = tempRight.x / 2f;
			chicken [0].transform.position = new Vector3 (tempLeft.x, 4.06f, 0.0f);
			chicken [4].transform.position = new Vector3 (tempRight.x, 4.06f, 0.0f);
			chicken [1].transform.position = new Vector3 (tempMiddelLeft, 4.06f, 0.0f);
			chicken [3].transform.position = new Vector3 (tempMiddelRight, 4.06f, 0.0f);
		}
	}

	public float LeftX {
		get { return leftX; }
	}

	public float RightX {
		get { return rightX; }
	}

	// Use this for initialization
//	void Start () {
//		leftX = maxLeftX.transform.position.x;
//		rightX = maxRightX.transform.position.x;
//		Vector3 tempLeft = maxLeftX.transform.position;
//		Vector3 tempRight = maxRightX.transform.position;
//		float tempMiddelLeft = tempLeft.x / 2f;
//		float tempMiddelRight = tempRight.x / 2f;
//		chicken [0].transform.position = new Vector3 (tempLeft.x, 4.06f, 0.0f);
//		chicken [4].transform.position = new Vector3 (tempRight.x, 4.06f, 0.0f);
//		chicken [1].transform.position = new Vector3 (tempMiddelLeft, 4.06f, 0.0f);
//		chicken [3].transform.position = new Vector3 (tempMiddelRight, 4.06f, 0.0f);
//	}
}
