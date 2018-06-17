using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelController : MonoBehaviour {
	public static NextLevelController instance = null;
	[SerializeField] private Text pointText;
	[SerializeField] private Text timeText;
	[SerializeField] private Text levelText;
	private int pointToNextLevel;
	private int timeToEnd;
	private int level;

	void Awake () {
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		level = PlayerPrefs.GetInt ("level", level);
		levelText.text = "" + level;
		pointToNextLevel = 25 * level;
		timeToEnd = 25 * level * 2;
		pointText.text = "" + pointToNextLevel;
		timeText.text = "" + timeToEnd;
		PlayerPrefs.SetInt ("pointToNextLevel", pointToNextLevel);
		PlayerPrefs.SetInt ("timeToEnd", timeToEnd);
	}

	public void GoToGamePlay() {
		SceneManager.LoadScene (1);
	}
}
