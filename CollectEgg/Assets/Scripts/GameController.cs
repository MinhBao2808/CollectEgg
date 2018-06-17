using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public static GameController instance =  null;
	[SerializeField] private GameObject[] chickenSpawmPoint;
	[SerializeField] private GameObject characterSpawmPoint;
	[SerializeField] private GameObject[] eggsAndShit;
	[SerializeField] private GameObject gameOverMenu;
	[SerializeField] private GameObject nextLevelButton;
	[SerializeField] private GameObject playAgainButton;
	[SerializeField] private GameObject[] medal;
	[SerializeField] private GameObject[] characterSpawn;
	[SerializeField] private Text bestScoreText;
	[SerializeField] private int maxEggsOnScence;
	[SerializeField] private int totalEggs;
	[SerializeField] private int EggsPerSpawn;
	[SerializeField] private Text pointText;
	[SerializeField] private Text totalScoreText;
	[SerializeField] private Text resultScoreText;
	private int gamePoint;
	const float spawnDelay = 2f;
	private bool gameOver = false;
	private int pointToNextLevel;
	private int level;
	private int totalPoint;
	private int highScore;
	private string characterName;
	private int eggsOnScence = 0;
	private int coinPoints = 0;
	// Use this for initialization

	void Awake() {
		if (instance == null) {
			instance = this;
		}
		characterName = PlayerPrefs.GetString ("characterName", characterName);
		if (characterName == "Fox") {
			GameObject characterInGame = Instantiate (characterSpawn [0]) as GameObject;
			characterInGame.transform.position = characterSpawmPoint.transform.position;
		}
		if (characterName == "WhiteDog") {
			GameObject characterInGame = Instantiate (characterSpawn [1]) as GameObject;
			characterInGame.transform.position = characterSpawmPoint.transform.position;
		}
		if (characterName == "YellowDog") {
			GameObject characterInGame = Instantiate (characterSpawn [3]) as GameObject;
			characterInGame.transform.position = characterSpawmPoint.transform.position;
		}
		if (characterName == "BrownDog") {
			GameObject characterInGame = Instantiate (characterSpawn [2]) as GameObject;
			characterInGame.transform.position = characterSpawmPoint.transform.position;
		}
		if (characterName == "WhiteCat") {
			GameObject characterInGame = Instantiate (characterSpawn [4]) as GameObject;
			characterInGame.transform.position = characterSpawmPoint.transform.position;
		}
		if (characterName == "RedCat") {
			GameObject characterInGame = Instantiate (characterSpawn [5]) as GameObject;
			characterInGame.transform.position = characterSpawmPoint.transform.position;
		}
		if (characterName == "YellowCat") {
			GameObject characterInGame = Instantiate (characterSpawn [6]) as GameObject;
			characterInGame.transform.position = characterSpawmPoint.transform.position;
		}
	}

	void Start () {
		coinPoints = PlayerPrefs.GetInt("coinPoint", coinPoints);
		totalPoint = PlayerPrefs.GetInt ("totalScore", totalPoint);
		totalScoreText.text = "" + totalPoint;
		highScore = PlayerPrefs.GetInt ("highScore", highScore);
		pointToNextLevel = PlayerPrefs.GetInt ("pointToNextLevel", pointToNextLevel);
		Debug.Log (pointToNextLevel);
		level = PlayerPrefs.GetInt ("level", level);
		StartCoroutine (spawn ());
	}

	public bool GameOver {
		get { return gameOver; }
	}

	public int GamePoint {
		get { return gamePoint; } 
	}

	IEnumerator spawn () {
		if (gameOver == false) {
			if (EggsPerSpawn > 0 && eggsOnScence < totalEggs) {
				for (int i = 0; i < EggsPerSpawn; i++) {
					if (eggsOnScence < maxEggsOnScence) {
						GameObject newEgg = Instantiate (eggsAndShit [Random.Range (0, 3)]) as GameObject;
						newEgg.transform.position = chickenSpawmPoint [Random.Range (0, 5)].transform.position;
						eggsOnScence += 1;
					}
				}
				yield return new WaitForSeconds (spawnDelay);
				StartCoroutine (spawn ());
			}
		}
	}

	public void  removeEggsOnScence() {
		if (eggsOnScence > 0) {
			eggsOnScence -= 1;
		}
	}

	public void CaculatePoint() {
		gamePoint = gamePoint + 10;
		totalPoint = totalPoint + 10;
		pointText.text = "" + gamePoint;
		totalScoreText.text = "" + totalPoint;
		if (highScore < gamePoint) {
			highScore = gamePoint;
			PlayerPrefs.SetInt ("highScore", highScore);
		}
	}

	public void CaculateCoin() {
		coinPoints = coinPoints + 10;
		PlayerPrefs.SetInt("coinPoint", coinPoints);
	}

	public void DeletePoint() {
		gamePoint = gamePoint - 10;
		totalPoint = totalPoint - 10;
		if (gamePoint < 0) {
			gamePoint = 0;
			totalPoint = 0;
		}
		pointText.text = "" + gamePoint;
		totalScoreText.text = "" + totalPoint;
	}

	public void IsGameOver() {
		gameOver = true;
		PlayerPrefs.SetInt ("totalScore", totalPoint);
		gameOverMenu.SetActive (true);
		if (totalPoint >= 100 && totalPoint < 150) {
			medal[0].SetActive (true);
		} else if (totalPoint >= 150 && totalPoint < 300) {
			medal[1].SetActive (true);
		} else if (totalPoint > 300) {
			medal[2].SetActive (true);
		}
		resultScoreText.text = "" + gamePoint;
		bestScoreText.text = "" + highScore;
		if (gamePoint < pointToNextLevel) {
			playAgainButton.SetActive (true);
			nextLevelButton.SetActive (false);

		} else {
			nextLevelButton.SetActive (true);
			playAgainButton.SetActive (false);
		}
	}

	public void PlayGameAgain () {
		SceneManager.LoadScene (0);
	}

	public void GoToNextLevel() {
		level = level + 1;
		PlayerPrefs.SetInt ("level", level);
		SceneManager.LoadScene (2);
	}
}
