using UnityEngine;
using System.Collections;

public class CGameOver : MonoBehaviour {
	public GameObject goGameMan;
	
	// Use this for initialization
	void Start () {
		
	}

	/// <summary>
	/// Inits the game over.
	/// </summary>
	public void initGameOver() {
		// Rigidbodyをrigsに全て列挙する
		Rigidbody[] rigs = 
			GameObject.FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];

		// すべてのRigidbodyを休眠させる
		foreach(Rigidbody rig in rigs) {
			rig.Sleep ();
		}
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
