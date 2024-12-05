using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void GoToSkinSelection()
    {
        SceneManager.LoadScene("SkinSelection");
    }
    public void Resetart()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
