using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllPlayer : MonoBehaviour {
	[SerializeField] private float maxBoundPlayerLeft;
	[SerializeField] private float macBoundPlayerRight;
	[SerializeField] private float speed;
	bool isLeftPressed, isRightPressed;
	private bool isMove = false;

	void Start() {
		maxBoundPlayerLeft = FixScaleController.instance.LeftX;
		macBoundPlayerRight = FixScaleController.instance.RightX;
	}

	void Update() {
		if (Input.GetKey (KeyCode.RightArrow) && transform.position.x <= macBoundPlayerRight) {
			transform.localScale = new Vector3 (-1, 1, 1);
			transform.Translate (speed * Time.deltaTime, 0, 0);
		}
			if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= maxBoundPlayerLeft) {
			transform.localScale = new Vector3 (1, 1, 1);
			transform.Translate (-speed * Time.deltaTime, 0, 0);
		}
	}

	public void LeftButtonDown() {
		isLeftPressed = true;
	}
	public void UpdateLeftButton(){
		if (isLeftPressed && transform.position.x >= maxBoundPlayerLeft) {
			transform.localScale = new Vector3 (1, 1, 1);
			transform.Translate (-speed * Time.deltaTime, 0, 0);
			isMove = true;
		}
	}
	public void LeftButtonUp(){
		isLeftPressed = false;
		isMove = false;
	}

	public void RightButtonDown() {
		isRightPressed = true;
	}
	public void UpdateRightButtonDown () {
		if (isRightPressed && transform.position.x <= macBoundPlayerRight) {
			transform.localScale = new Vector3 (-1, 1, 1);
			transform.Translate (speed * Time.deltaTime, 0, 0);
			isMove = true;
		}
	}
	public void RightButtonUp () {
		isRightPressed = false;
		isMove = false;
	}

	public bool isPlayerMove() {
		return isMove;
	}

	public bool isMoveLeft() {
		return isLeftPressed;
	}

	public bool isMoveRight() {
		return isRightPressed;
	}
}
