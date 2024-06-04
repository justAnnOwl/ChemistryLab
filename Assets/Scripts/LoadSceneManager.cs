using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
      public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadLabMenu()
    {
        SceneManager.LoadScene(1);
    }
      public void LoadParagraphMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadParagraph_22_9()
    {
        SceneManager.LoadScene(3);
    }
      public void LoadWorkspace()
    {
        SceneManager.LoadScene(4);
    }
     public void LoadSavwScenesMenu()
    {
        SceneManager.LoadScene(5);
    }
      
    public void Exit()
    {
        Debug.Log("Приложение закрыто");
        Application.Quit();
    }

}
