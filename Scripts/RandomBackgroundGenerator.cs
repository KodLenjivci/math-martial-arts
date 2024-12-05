using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBackgroundGenerator : MonoBehaviour
{
    public Sprite[] backgrounds;
    public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        int r;
        r = Random.Range(0, backgrounds.Length - 1);
        background.GetComponent<SpriteRenderer>().sprite = backgrounds[r];
    }
}
