using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameOnCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("MainMenu");
    }
}