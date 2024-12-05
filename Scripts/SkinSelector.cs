using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinSelector : MonoBehaviour
{
    public GameObject[] charactersP1;
    public GameObject[] charactersP2;

    public int selectedP1 = 0;
    public int selectedP2 = 0;

    public void NextCharacterP1()
    {
        charactersP1[selectedP1].SetActive(false);
        selectedP1 = (selectedP1 + 1) % charactersP1.Length;
        charactersP1[selectedP1].SetActive(true);
    }
    public void NextCharacterP2()
    {
        charactersP2[selectedP2].SetActive(false);
        selectedP2 = (selectedP2 + 1) % charactersP2.Length;
        charactersP2[selectedP2].SetActive(true);
    }

    public void PreviousCharacterP1()
    {
        charactersP1[selectedP1].SetActive(false);
        selectedP1--;
        if (selectedP1<0)
        {
            selectedP1 += charactersP1.Length;
        }
        charactersP1[selectedP2].SetActive(true);
    }
    public void PreviousCharacterP2()
    {
        charactersP2[selectedP2].SetActive(false);
        selectedP2--;
        if (selectedP2 < 0)
        {
            selectedP2 += charactersP2.Length;
        }
        charactersP2[selectedP2].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedP1", selectedP1);
        PlayerPrefs.SetInt("selectedP2", selectedP2);
        SceneManager.LoadScene("MainScene");
    }

}
