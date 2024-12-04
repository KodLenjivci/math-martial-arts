using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public Animator p1Animator;
    public Animator p2Animator;

    public TextMeshProUGUI questionText;
    [HideInInspector]
    public int randQuestion;

    [SerializeField]
    Questions q;

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

       

    }
    private void setQuestion()
    {
        randQuestion = 1;
        if (randQuestion == 0)
        {
            int a = Random.Range(0, 100);
            int b = Random.Range(0, 100);
            int c = Random.Range(0, 100);
            questionText.text = q.SumThreeNumbers(a, b, c);

            buttons[correctButtonIndex].GetComponentInChildren<TextMeshProUGUI>().text = (a + b + c).ToString();
            for (int i = 0; i < buttons.Length; i++)
            {
                if (correctButtonIndex != i)
                {
                    buttons[i].GetComponentInChildren<TextMeshProUGUI>().text = Random.Range(0, 300).ToString();
                }
            }
        }else if (randQuestion==1)
        {
            int a = Random.Range(1, 100);
            int b = Random.Range(1, 100);
            int x = Random.Range(1, 20);

            int c = a * x + b;

            questionText.text = q.SolveEquation(a, b, x);

            buttons[correctButtonIndex].GetComponentInChildren<TextMeshProUGUI>().text = (x).ToString();
            for (int i = 0; i < buttons.Length; i++)
            {
                if (correctButtonIndex != i)
                {
                    buttons[i].GetComponentInChildren<TextMeshProUGUI>().text = Random.Range(1, 100).ToString();
                }
            }
        }
    
    }



    private void setNewRound()//zapocinjemo novu rundu
    {
        if (p1Health <= 0)
        {
            p1Animator.SetTrigger("Fall");
            p2Animator.SetTrigger("Win");
        }
        else if (p2Health <= 0)
        {
            p1Animator.SetTrigger("Win");
            p2Animator.SetTrigger("Fall");
        }
        else
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
            setQuestion();
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

                p1Animator.SetTrigger("Shoot");
                p2Health -= damage;
                p2Animator.SetTrigger("Hurt");
            }
            else if(!isP1Answer && isP2Answer)
            {
                p2Animator.SetTrigger("Shoot");
                p1Health -= damage;
                p1Animator.SetTrigger("Hurt");
            }
            else if(isP1Answer && isP2Answer)
            {
                if (p1TimeForAnswer < p2TimeForAnswer)
                {

                    p1Animator.SetTrigger("Shoot");
                    p2Health -= damage;
                    p2Animator.SetTrigger("Hurt");
                }
                else
                {
                    p2Animator.SetTrigger("Shoot");
                    p1Health -= damage;
                    p1Animator.SetTrigger("Hurt");
                }
            }
            
            p1TimeForAnswer = 0;
            p2TimeForAnswer = 0;
        }

        setNewRound();
        
    }
}
