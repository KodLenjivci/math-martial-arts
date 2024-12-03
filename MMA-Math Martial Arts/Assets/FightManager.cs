using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    public Button[] buttons;//niz dugmica
    private int correctButtonIndex;//rendom tacno dugme od 3

    private void Start()
    {
        correctButtonIndex = Random.Range(0, buttons.Length);
        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonIndex = i;
            buttons[i].onClick.AddListener(() => OnButtonPress(buttonIndex)); // Dodaj listener na svaki onclick na dugme
        }
    }

    // Poziva se svaki put kad kliknes
    void OnButtonPress(int buttonIndex)
    {
        if (buttonIndex == correctButtonIndex)
        {
            Debug.Log("TACNOOOO :)");
        }
        else
        {
            Debug.Log("NETACNO >:(");
        }
    }
}
