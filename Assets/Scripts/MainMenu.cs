using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public string newGameScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
        Cursor.lockState = CursorLockMode.Locked; //скрытие курсора
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
