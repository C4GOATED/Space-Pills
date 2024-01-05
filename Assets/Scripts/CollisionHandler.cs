using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public PauseManager pauseManager;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            // Load the desired scene (Replace "YourSceneName" with the name of your scene)
            SceneManager.LoadScene("GameOver");
        }
    }
}