using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Canvas LevelsCanvas;

    public Canvas MenuCanvas;

    public static string CurrentScene;


    void Start()
    {
        LevelsCanvas.gameObject.SetActive(false);
        CurrentScene = "Menu";
    }


    public void ButStart()
    {
        LevelsCanvas.gameObject.SetActive(true);
        MenuCanvas.gameObject.SetActive(false);
    }

    public void ButExit()
    {
        
    }
    
    public void ButBack()
    {
        LevelsCanvas.gameObject.SetActive(false);
        MenuCanvas.gameObject.SetActive(true);
    }

    public void ButTutorial()
    {
        CurrentScene = "TutorialMap";
        SceneManager.LoadScene(CurrentScene);
    }
    
    public void ButLevel1() 
    {
        CurrentScene = "Level1";
        SceneManager.LoadScene("Level1");
    }
    
    public void ButLevel2() 
    {
        CurrentScene = "Level2";
        SceneManager.LoadScene(CurrentScene);
    }
    
    public void ButLevel3() 
    {
        CurrentScene = "Level3";
        SceneManager.LoadScene(CurrentScene);
    }
    
    public void ButMenu() 
    {
        CurrentScene = "Menu";
        SceneManager.LoadScene(CurrentScene);
    }
    
}
