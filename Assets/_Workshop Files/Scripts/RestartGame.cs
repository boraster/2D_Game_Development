using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame: MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Trigger entered");
            SceneManager.LoadScene(0);
        }

    }

}

