using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public string levelName;

	public void SceneChange() {
		SceneManager.LoadScene(levelName);
	}
}
