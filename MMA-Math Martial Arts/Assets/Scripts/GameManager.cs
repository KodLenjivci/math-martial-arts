using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject selectedSkin1;
    public GameObject selectedSkin2;

    public GameObject p1;
    public GameObject p2;

    private Sprite p1Sprite;
    private Sprite p2Sprite;

    private RuntimeAnimatorController p1Animator;
    private RuntimeAnimatorController p2Animator;

    // Start is called before the first frame update
    void Start()
    {
        p1Sprite = selectedSkin1.GetComponent<SpriteRenderer>().sprite;
        p2Sprite = selectedSkin2.GetComponent<SpriteRenderer>().sprite;

        p1.GetComponent<SpriteRenderer>().sprite = p1Sprite;
        p2.GetComponent<SpriteRenderer>().sprite = p2Sprite;

        p1Animator = selectedSkin1.GetComponent<Animator>().runtimeAnimatorController;
        p2Animator = selectedSkin2.GetComponent<Animator>().runtimeAnimatorController;

        p1.GetComponent<Animator>().runtimeAnimatorController = p1Animator;
        p2.GetComponent<Animator>().runtimeAnimatorController = p2Animator;
    }
}
