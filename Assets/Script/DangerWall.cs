using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour {

	// オブジェクトと接触した時に呼ばれるコールバック
	void OnCollisionEnter(Collision hit)
	{
		if (hit.gameObject.CompareTag("Player")) {
			
			// 現在のシーン番号を取得
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;
			
			// 現在のシーンを再読込する
			SceneManager.LoadScene(sceneIndex);
		}
	}
}
