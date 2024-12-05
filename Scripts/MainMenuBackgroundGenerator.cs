using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBackgroundGenerator : MonoBehaviour
{
    public Sprite[] backgrounds;
    public GameObject background;

    public float timeToChangeBackground = 15f;


    // Start is called before the first frame update
    void Start()
    {
        int r;
        r = Random.Range(0, backgrounds.Length - 1);
        background.GetComponent<SpriteRenderer>().sprite = backgrounds[r];
    }
    private void Update()
    {
        if (timeToChangeBackground <= 0)
        {
            int r;
            r = Random.Range(0, backgrounds.Length - 1);
            background.GetComponent<SpriteRenderer>().sprite = backgrounds[r];
            timeToChangeBackground = 15f;
        }
        else
            timeToChangeBackground -= Time.deltaTime;
    }
}
