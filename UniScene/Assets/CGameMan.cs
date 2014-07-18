using UnityEngine;
using System.Collections;

public class CGameMan : MonoBehaviour {
	public GameObject goTitle;
	public GameObject goGame;
	public GameObject goGameOver;
	public GUIText textScore;

	// scene teigi
	public enum SC {
		SC_NONE = -1,
		SC_TITLE,
		SC_GAME,
		SC_GAMEOVER,
	};

	// genzai no scene
	public SC iNowScene {get; set;}

	// tsugi no scene
	public SC iNextScene {get; set;}

	// score
	private int iScore = 0;

	/// <summary>
	/// add wo score ni tasu
	/// </summary>
	/// <param name="add">Add.</param>
	public void addScore(int add) {
		iScore += add;
	}

	// Use this for initialization
	void Start () {
		iNextScene = SC.SC_TITLE;
		iNowScene = SC.SC_NONE;
	}
	
	// Update is called once per frame
	void Update () {
		textScore.text = iScore.ToString();

		// init
		if (iNextScene != SC.SC_NONE) {
			iNowScene = iNextScene;
			iNextScene = SC.SC_NONE;
			switch (iNowScene) {
			case SC.SC_TITLE:
				goTitle.SetActive(true);
				goGame.SetActive(false);
				break;
			case SC.SC_GAME:
				iScore = 0;
				goTitle.SetActive(false);
				goGame.SetActive(true);
				goGameOver.SetActive(false);
				break;
			case SC.SC_GAMEOVER:
				goGameOver.SetActive(true);
				break;
			}
		}
	}

	public void ChangeScene(SC nx) {
		iNextScene = nx;
	}
}
