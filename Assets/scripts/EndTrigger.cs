using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject player;

    void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject == player)
        {
            print("Player hit the finish line");
            gameManager.CompleteLevel();
        }
        
    }
        
}
