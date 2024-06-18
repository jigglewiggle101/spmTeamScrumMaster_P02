using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Main Menu Scenes Changer //
    public void ChangeToArcadeMenu()
    {
        Debug.Log("Arcade Menu Page");
        SceneManager.LoadScene("ArcadeMenu");
    }

    public void ChangeToFreePlayMenu()
    {
        Debug.Log("Free Play Menu Page");
        SceneManager.LoadScene("FreePlayMenu");
    }

    public void ChangeToSettingsPage()
    {
        Debug.Log("Settings Page");
        SceneManager.LoadScene("SettingsPage");
    }

    // Arcade Game Menu Scene Changer //

    public void ArcadeGame()
    {
        Debug.Log("Arcade Game");
        SceneManager.LoadScene("ArcadeGame");
    }

    public void ArcadeLoadGame()
    {
        Debug.Log("Going to Loading Page");
        SceneManager.LoadScene("LoadArcadeGame");
    }

    public void ArcadeInstructions()
    {
        Debug.Log("Arcade Instructions");
        SceneManager.LoadScene("ArcadeInstructions");
    }

    // Free Play Menu Scene Changer // 

    public void FreePlayGame()
    {
        Debug.Log("FP Game");
        SceneManager.LoadScene("FreePlayGame");
    }

    public void FreePlayLoadGame()
    {
        Debug.Log("Going to Loading Page");
        SceneManager.LoadScene("LoadFreePlayGame");
    }

    public void FreePlayInstructions()
    {
        Debug.Log("FP Instructions");
        SceneManager.LoadScene("FreePlayInstructions");
    }


    // Scene Changer to Go Back //

    public void BackToMainMenu()
    {
        Debug.Log("Going Back to Main Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void BackToArcadeMenu()
    {
        Debug.Log("Going Back to Arcade Menu");
        SceneManager.LoadScene("ArcadeMenu");
    }

    public void BackToFreePlayMenu()
    {
        Debug.Log("Going Back to Free Play Menu");
        SceneManager.LoadScene("FreePlayMenu");
    }


    // Scene Changer to Quit Game //
    public void QuitGame()
    {
        Debug.Log("QUIT!!!");
        Application.Quit();
    }
}
