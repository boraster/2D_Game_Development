using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLEvel : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Level End triggered");
            StartCoroutine(LoadLevel());
        }
    }

    private IEnumerator LoadLevel()
    {
        AsyncOperation loadScene = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        while (!loadScene.isDone)
        {
            yield return null;
        }
    }
}
