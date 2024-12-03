using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    public Button[] buttons;//niz dugmica
    private int correctButtonIndex;//rendom tacno dugme od 3
    private bool p1 = true;

    public int p1Health = 100;
    public int p2Health = 100;

    private float p1TimeForAnswer;
    private float p2TimeForAnswer;

    private bool isP1Answer;
    private bool isP2Answer;

    public GameObject player1;
    public GameObject player2;

    public int damage;


    private void Start()
    {
        setNewRound();
    }
    private void Update()
    {
        if (p1)
        {
            p1TimeForAnswer += Time.deltaTime;
        }
        if (!p1)
        {
            p2TimeForAnswer += Time.deltaTime;
        }

        if (p1Health<=0)
        {
            Destroy(player1);
        }
        else if (p2Health<=0)
        {
            Destroy(player2);
        }

    }


    private void setNewRound()//zapocinjemo novu rundu
    {
         correctButtonIndex = Random.Range(0, buttons.Length);
         for (int i = 0; i < buttons.Length; i++)
         {
            int buttonIndex = i;
            buttons[i].onClick.RemoveAllListeners();//brise svaki listenera sa buttna
         }

        if (p1)
        {
            addingEventListeners("P1");
        }
        else
        {
            addingEventListeners("P2");
        }
    }

    void addingEventListeners(string player)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonIndex = i;
            buttons[i].onClick.AddListener(() => OnButtonPress(buttonIndex, player)); // Dodaj listener na svaki onclick na dugme
            p1TimeForAnswer += Time.deltaTime;
        }
    }

    // Poziva se svaki put kad kliknes
    void OnButtonPress(int buttonIndex,string player)
    {
        if (buttonIndex == correctButtonIndex)
        {
            Debug.Log(player + " je tacno odgovorio :)");
            Debug.Log(p1TimeForAnswer + " " + p2TimeForAnswer);
            if (player.Equals("P1"))
            {
                isP1Answer = true;
            }
            else
            {
                isP2Answer = true;
            }
        }
        else if (buttonIndex != correctButtonIndex)
        {
            Debug.Log(player + " je netacno odgovorio >:(");
            Debug.Log(p1TimeForAnswer + " " + p2TimeForAnswer);

            if (player.Equals("P1"))
            {
                isP1Answer = false;
            }
            else
            {
                isP2Answer = false;
            }
        }
        p1 = !p1;
        if (p1TimeForAnswer > 0 && p2TimeForAnswer > 0)
        {
            if (isP1Answer && !isP2Answer)
            {
                p2Health -= damage;
            }
            else if(!isP1Answer && isP2Answer)
            {
                p1Health -= damage;
            }
            else if(isP1Answer && isP2Answer)
            {
                if (p1TimeForAnswer < p2TimeForAnswer)
                {
                    p2Health -= damage;
                }
                else
                {
                    p1Health -= damage;
                }
            }
            
            p1TimeForAnswer = 0;
            p2TimeForAnswer = 0;
        }

        setNewRound();
        
    }
}
