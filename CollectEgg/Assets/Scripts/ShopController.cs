using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour {
	public static ShopController instance = null;
	[SerializeField] private Text coinText;
	[SerializeField] private Button[] gamePlayer;
	private int coinPoint;
	private int whiteDog, yellowDog, brownDog, whiteCat, redCat, yellowCat = 200;
	private int buyWhiteDog, buyYellowDog, buyBrowDog, buyWhiteCat, buyRedCat, buyYellowCat = 0;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	void Start() {
		coinText.text = "" + coinPoint;
		//coinPoint = PlayerPrefs.GetInt ("coinPoint", coinPoint);
		buyWhiteDog = PlayerPrefs.GetInt ("22a", buyWhiteDog);
		buyYellowDog = PlayerPrefs.GetInt ("22b", buyYellowDog);
		buyBrowDog = PlayerPrefs.GetInt ("22c", buyBrowDog);
		buyWhiteCat = PlayerPrefs.GetInt ("22d", buyWhiteCat);
		buyRedCat = PlayerPrefs.GetInt ("22e", buyRedCat);
		buyYellowCat = PlayerPrefs.GetInt ("22f", buyYellowCat);
		if (buyWhiteDog == 1) {
			gamePlayer [0].GetComponent<Button> ().interactable = false;
		}
		if (buyYellowDog == 2) {
			gamePlayer [1].GetComponent<Button> ().interactable = false;
		}
		if (buyBrowDog == 3) {
			gamePlayer [2].GetComponent<Button> ().interactable = false;
		}
		if (buyWhiteCat == 4) {
			gamePlayer [3].GetComponent<Button> ().interactable = false;
		}
		if (buyRedCat == 5) {
			gamePlayer [4].GetComponent<Button> ().interactable = false;
		}
		if (buyYellowCat == 6) {
			gamePlayer [5].GetComponent<Button> ().interactable = false;
		}
	}

	public void BuyWhiteDog () {
		if (whiteDog <= coinPoint) {
			gamePlayer [0].GetComponent<Button> ().interactable = false;
			coinPoint = coinPoint - whiteDog;
			buyWhiteDog = 1;
			PlayerPrefs.SetInt ("22a", buyWhiteDog);
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coin", coinPoint);
		}
	}

	public void BuyYellowDog () {
		if (yellowDog <= coinPoint) {
			gamePlayer [1].GetComponent<Button> ().interactable = false;
			coinPoint = coinPoint - yellowDog;
			buyYellowDog = 2;
			PlayerPrefs.SetInt ("22b", buyYellowDog);
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coin", coinPoint);
		}
	}

	public void BuyBrowDog() {
		if (brownDog <= coinPoint) {
			gamePlayer [2].GetComponent<Button> ().interactable = false;
			coinPoint = coinPoint - brownDog;
			buyBrowDog = 3;
			PlayerPrefs.SetInt ("22c", buyBrowDog);
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coin", coinPoint);
		}
	}

	public void BuyWhiteCat() {
		if (whiteCat <= coinPoint) {
			gamePlayer [3].GetComponent<Button> ().interactable = false;
			coinPoint = coinPoint - whiteCat;
			buyWhiteCat = 4;
			PlayerPrefs.SetInt ("22d", buyWhiteCat);
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coin", coinPoint);
		}
	}

	public void BuyRedCat() {
		if (redCat <= coinPoint) {
			gamePlayer [4].GetComponent<Button> ().interactable = false;
			coinPoint = coinPoint - redCat;
			buyRedCat = 5;
			PlayerPrefs.SetInt ("22e", buyRedCat);
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coin", coinPoint);
		}
	}

	public void BuyYellowCat() {
		if (yellowCat <= coinPoint) {
			gamePlayer [5].GetComponent<Button> ().interactable = false;
			coinPoint = coinPoint - yellowCat;
			buyYellowCat = 6;
			PlayerPrefs.SetInt ("22f", buyYellowCat);
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coin", coinPoint);
		}
	}

	public void ReturnMenu () {
		SceneManager.LoadScene (0);
	}
}
