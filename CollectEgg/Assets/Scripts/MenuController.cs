using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {
	public static MenuController instance = null;
	private int level;
	private int highScore;
	private int totalScore;
	[SerializeField] private GameObject chooseChracterMenu;
	[SerializeField] private Text highScoreText;
	private string characterName;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	void Start() {
		totalScore = 0;
		PlayerPrefs.SetInt ("totalScore", totalScore);
		highScore = PlayerPrefs.GetInt ("highScore", highScore);
		highScoreText.text = "" + highScore;
		level = 1;
		PlayerPrefs.SetInt ("level", level);
	}

	public void GoToNextLevel () {
		SceneManager.LoadScene (2);
	}

	public void GoToShop() {
		SceneManager.LoadScene (3);
	}

	public void ChooseCharacter() {
		chooseChracterMenu.SetActive (true);
	}

	public void ChooseFox () {
		characterName = "Fox";
		PlayerPrefs.SetString ("characterName", characterName);
		chooseChracterMenu.SetActive (false);
	}

	public void ChooseWhiteDog() {
		characterName = "WhiteDog";
		PlayerPrefs.SetString ("characterName", characterName);
		chooseChracterMenu.SetActive (false);
	}

	public void ChooseYellowDog() {
		characterName = "YellowDog";
		PlayerPrefs.SetString ("characterName", characterName);
		chooseChracterMenu.SetActive (false);
	}

	public void ChooseBrownDog() {
		characterName = "BrownDog";
		PlayerPrefs.SetString ("characterName", characterName);
		chooseChracterMenu.SetActive (false);
	}

	public void ChooseWhiteCat() {
		characterName = "WhiteCat";
		PlayerPrefs.SetString ("characterName", characterName);
		chooseChracterMenu.SetActive (false);
	}

	public void ChooseRedCat() {
		characterName = "RedCat";
		PlayerPrefs.SetString ("characterName", characterName);
		chooseChracterMenu.SetActive (false);
	}

	public void ChooseYellowCat() {
		characterName = "YellowCat";
		PlayerPrefs.SetString ("characterName", characterName);
		chooseChracterMenu.SetActive (false);
	}
}
