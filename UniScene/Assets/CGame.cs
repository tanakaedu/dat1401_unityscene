using UnityEngine;
using System.Collections;

public class CGame : MonoBehaviour {
	public GameObject goGameMan;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			goGameMan.SendMessage("addScore",100);
		}
		else if (Input.GetKeyDown(KeyCode.G)) {
			goGameMan.SendMessage("ChangeScene",CGameMan.SC.SC_GAMEOVER);
		}
	}
}
