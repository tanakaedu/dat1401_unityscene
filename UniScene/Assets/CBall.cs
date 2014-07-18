using UnityEngine;
using System.Collections;

public class CBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// 自分自身を削除する
	/// </summary>
	public void DestroyMe() {
		Destroy (gameObject);
	}
}
