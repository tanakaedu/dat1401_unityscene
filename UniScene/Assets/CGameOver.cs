using UnityEngine;
using System.Collections;

public class CGameOver : MonoBehaviour {
	public GameObject goGameMan;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			//((CGameMan)goGameMan.GetComponent<CGameMan>()).iNextScene
			//	= CGameMan.SC.SC_GAME;
			goGameMan.SendMessage("ChangeScene",CGameMan.SC.SC_TITLE);
		}
	}
}
