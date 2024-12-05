using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Random = UnityEngine.Random;

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

    public Image p1Arrow;
    public Image p2Arrow;

    public TextMeshProUGUI stopWatchP1;
    public TextMeshProUGUI stopWatchP2;

    public TextMeshProUGUI HealthTextP1;
    public TextMeshProUGUI HealthTextP2;

    public Image WinScreen;
    public Image winPlayerImage;

    public Sprite igrac1;
    public Sprite igrac2;

    public GameObject[] UIElemetns;

    public AudioSource sourceP1;
    public AudioSource sourceP2;

    public AudioClip clip;

    public GameObject HitParticleP1;
    public GameObject HitParticleP2;

    public Transform Player1Pos;
    public Transform Player2Pos;

    private void Start()
    {
        setNewRound();
    }


    private void Update()
    {
        player1 = GameObject.FindWithTag("P1");
        p1Animator = player1.GetComponent<Animator>();
        sourceP1 = player1.GetComponent<AudioSource>();
        Player1Pos = player1.GetComponent<Transform>();


        player2 = GameObject.FindWithTag("P2");
        p2Animator = player2.GetComponent<Animator>();
        sourceP2 = player2.GetComponent<AudioSource>();
        Player2Pos = player2.GetComponent<Transform>();


        if (p1)
        {
            p1TimeForAnswer += Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(p1TimeForAnswer); 
            stopWatchP1.text = time.ToString(@"mm\:ss\:ff");
        }
        if (!p1)
        {
            p2TimeForAnswer += Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(p2TimeForAnswer);
            stopWatchP2.text = time.ToString(@"mm\:ss\:ff");
        }
    }
    private void setQuestion()
    {
        randQuestion = Random.Range(0,10);
        //suma 3 broja
        if (randQuestion == 0)
        {
            int a = Random.Range(0, 100);
            int b = Random.Range(0, 50);
            int c = Random.Range(0, 100);
            questionText.text = q.SumThreeNumbers(a, b, c);

            setButtons(a + b + c, 300);
        }
        //nadji x
        else if(randQuestion==1)
        {
            int a = Random.Range(1, 25);
            int b = Random.Range(1, 25);
            int x = Random.Range(1, 20);

            int c = a * x + b;

            questionText.text = q.SolveEquation(a, b, x);

            setButtons(x, 500);
        }

        //pretvaranje sata u minute
        else if(randQuestion == 2)
        {
            int hours = Random.Range(1, 24);
            int result = hours * 60;

            setButtons(result, hours * 60);
            questionText.text = q.ConvertHoursToMinutes(hours);
        }

        //sabiranje klikera
        else if(randQuestion == 3)
        {
            int a = Random.Range(1, 150);
            int b = Random.Range(1, 150);

            int resenje = a + b;


            questionText.text = q.HowMuchTheyGot(a, b);
            setButtons(resenje, 300);

        }

        //davanje klikera
        else if(randQuestion == 4)
        {
            int a = Random.Range(1, 125);
            int c = Random.Range(0, a);

            int resenje = a - c;

            questionText.text = q.GivingStuffToEachOther(a,c);

            setButtons(resenje, a);
        }

        //izraz sa 3 br
        else if (randQuestion == 5)
        {
            int a = Random.Range(1, 200);
            int b = Random.Range(1, 200);
            int c = Random.Range(1, 200);


            int result;
            string expression;


            if (Random.Range(0, 2) == 0)
            {
                result = a + b - c;
                expression = $"{a} + {b} - {c}";
            }
            else
            {

                if (a - b < 0)
                {
                    result = a + b - c;
                    expression = $"{a} + {b} - {c}";
                }
                else
                {
                    result = a - b + c;
                    expression = $"{a} - {b} + {c}";
                }
            }
            questionText.text = expression;
            setButtons(result, 400);
            
        }

        //pretvaranje iz m u cm,dm ili mm
        else if (randQuestion == 6)
        {
            int r = Random.Range(0, 3);
            int meters = Random.Range(1, 1000);
            switch (r)
            {
                case 0:
                    questionText.text = q.ConvertUnits(meters, "cenitimetara");
                    setButtons(meters * 100, 100000);
                    break;
                case 1:
                    questionText.text = q.ConvertUnits(meters, "decimetara");
                    setButtons(meters * 10, 10000);
                    break;
                case 2:
                    questionText.text = q.ConvertUnits(meters, "milimetara");
                    setButtons(meters * 1000, 1000000);
                    break;
            }
                
        }

        //povrsina kvadrata
        else if (randQuestion == 7)
        {
            int a = Random.Range(2, 25);
            questionText.text = q.SquareArea(a);
            setButtons(a * a, 625);
        }

        //povrsina pravougaonika
        else if (randQuestion == 8)
        {
            int a = Random.Range(2, 25);
            int b = Random.Range(2, 25);

            questionText.text = q.RectangleArea(a, b);
            setButtons(a * b, 625);
        }

        //obim kvadrata
        else if(randQuestion == 9)
        {
            int a = Random.Range(1, 100);
            questionText.text = q.SquarePerimiter(a);
            setButtons(4*a,400);
        }

        //obim pravougaonika
        else if(randQuestion == 10)
        {
            int a = Random.Range(0, 100);
            int b = Random.Range(0, 100);

            questionText.text = q.RectanglePerimiter(a,b);
            setButtons(2 * a + 2 * b, 400);
        }
    }

    private void setButtons(int result,int maxRandom)
    {
        buttons[correctButtonIndex].GetComponentInChildren<TextMeshProUGUI>().text = (result).ToString();
        for (int i = 0; i < buttons.Length; i++)
        {
            if (correctButtonIndex != i)
            {
                buttons[i].GetComponentInChildren<TextMeshProUGUI>().text = Random.Range(1, maxRandom).ToString();
            }
        }
    }

    private void setNewRound()//zapocinjemo novu rundu
    {
            if (p1Health <= 0)
            {
                p1Animator.SetTrigger("Fall");
                p2Animator.SetTrigger("Win");
                WinScreen.gameObject.SetActive(true);
                winPlayerImage.sprite = igrac2;
                for (int i = 0; i < UIElemetns.Length; i++)
                {
                    UIElemetns[i].gameObject.SetActive(false);
                }
            }
            else if (p2Health <= 0)
            {
                p1Animator.SetTrigger("Win");
                p2Animator.SetTrigger("Fall");
                WinScreen.gameObject.SetActive(true);
                winPlayerImage.sprite = igrac1;
                for (int i = 0; i < UIElemetns.Length; i++)
                {
                    UIElemetns[i].gameObject.SetActive(false);
                }
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
                    p1Arrow.gameObject.SetActive(true);
                    p2Arrow.gameObject.SetActive(false);
                    stopWatchP2.text = "00:00:00";
                }
                else
                {
                    addingEventListeners( "P2");
                    p1Arrow.gameObject.SetActive(false);
                    p2Arrow.gameObject.SetActive(true);
                    
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
                p1Correct();
            }
            else if(!isP1Answer && isP2Answer)
            {
                p2Correct();
            }
            else if(isP1Answer && isP2Answer)
            {
                if (p1TimeForAnswer < p2TimeForAnswer)
                {
                    p1Correct();
                }
                else
                {
                    p2Correct();
                }
            }
            
            p1TimeForAnswer = 0;
            p2TimeForAnswer = 0;
        }

        setNewRound();
        
    }

    void p1Correct()
    {
        p1Animator.SetTrigger("Shoot");
        p2Health -= damage;
        HealthTextP2.text = p2Health.ToString();
        sourceP1.pitch = Random.Range(0.9f,1.2f);
        sourceP1.PlayOneShot(clip);
        p2Animator.SetTrigger("Hurt");
        Instantiate(HitParticleP2,new Vector3(Player2Pos.position.x,Player2Pos.position.y),Quaternion.identity);
    }
    void p2Correct()
    {
        p2Animator.SetTrigger("Shoot");
        p1Health -= damage;
        HealthTextP1.text = p1Health.ToString();
        sourceP2.pitch = Random.Range(0.9f, 1.2f);
        sourceP2.PlayOneShot(clip);
        p1Animator.SetTrigger("Hurt");
        Instantiate(HitParticleP1, new Vector3(Player1Pos.position.x, Player1Pos.position.y), Quaternion.identity);
    }

}
