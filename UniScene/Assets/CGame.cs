using UnityEngine;
using System.Collections;

public class CGame : MonoBehaviour {
	public GameObject goGameMan;
	public GameObject goSphere;
	public float RAND_SPEED = 10.0f;
	public int SPHERE_MAX = 10;
	public Vector2 RAND_SIZE = new Vector2(9,5);

	/// <summary>
	/// Inits the game.
	/// </summary>
	public void initGame() {
		// ボールを追加する
		for (int i=0 ; i<SPHERE_MAX ; i++) {
			// Sphereを生成する
			GameObject go = (GameObject)Instantiate(goSphere,
			                                        new Vector2(
				Random.Range (-RAND_SIZE.x,RAND_SIZE.x),
				Random.Range (-RAND_SIZE.y,RAND_SIZE.y)),
			                                        Quaternion.identity);
			// 速度を設定する
			go.rigidbody.velocity = new Vector3(
				Random.Range (-RAND_SPEED,RAND_SPEED),
				Random.Range (-RAND_SPEED,RAND_SPEED),
				0
				);
			// sphereをGameオブジェクトの子供にする
			go.transform.parent = this.transform;
		}
	}
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (goGameMan.GetComponent<CGameMan>().iNowScene == CGameMan.SC.SC_GAME) {
			if (Input.GetKeyDown(KeyCode.A)) {
				goGameMan.SendMessage("addScore",100);
			}
			else if (Input.GetKeyDown(KeyCode.G)) {
				goGameMan.SendMessage("ChangeScene",CGameMan.SC.SC_GAMEOVER);
			}
		}
	}
}
