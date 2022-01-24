using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Level1()
    {
        SceneManager.LoadScene("M1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("M2");
    }
    public void level3()
    {
        SceneManager.LoadScene("M3");
    }
    public void level4()
    {
        SceneManager.LoadScene("M4");
    }
    public void level5()
    {
        SceneManager.LoadScene("M5");
    }
    public void level6()
    {
        SceneManager.LoadScene("M6");
    }
    public void level7()
    {
        SceneManager.LoadScene("M7");
    }
    public void level8()
    {
        SceneManager.LoadScene("M8");
    }
    public void level9()
    {
        SceneManager.LoadScene("M9");
    }
    public void level10()
    {
        SceneManager.LoadScene("M10");
    }
}
