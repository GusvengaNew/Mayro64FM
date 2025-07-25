using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
