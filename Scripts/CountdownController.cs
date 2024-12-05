using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownController : MonoBehaviour
{
    private int countDownTime = 3;
    public TextMeshProUGUI countDownText;
    public GameObject background;
    public GameObject[] uiElements;


    void Start()
    {
        for (int i = 0; i < uiElements.Length; i++)
        {
            uiElements[i].SetActive(false);
        }

        StartCoroutine(CountDownToStart());
    }
    
    IEnumerator CountDownToStart()
    {
        while(countDownTime > 0)
        {
            countDownText.text = countDownTime.ToString();
            Time.timeScale = 0;
            yield return new WaitForSecondsRealtime(1f);
            countDownTime--;

        }
        countDownText.text = "GO";
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 1;
        for (int i = 0; i < uiElements.Length; i++)
        {
            uiElements[i].SetActive(true);
        }
        countDownText.gameObject.SetActive(false);
        background.SetActive(false);
    }

}
