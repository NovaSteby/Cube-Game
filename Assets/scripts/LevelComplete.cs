
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel ()
    {
        print("Scene Change");
        print("Animation is called");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
