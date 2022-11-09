using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInput : MonoBehaviour
{

    [SerializeField] Collider _playerCollider;
    [SerializeField] Collider _AICollider;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            ReloadLevel();
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Main Menu");
        }

    }

    void ReloadLevel()
    {
        int activeSceneIndex =
            SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex);
    }

    

}
