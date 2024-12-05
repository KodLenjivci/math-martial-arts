using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] characterP1Prefabs;
    public Transform P1spawnPoint;

    public GameObject[] characterP2Prefabs;
    public Transform P2spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        int selectedP1Character = PlayerPrefs.GetInt("selectedP1");
        int selectedP2Character = PlayerPrefs.GetInt("selectedP2");

        GameObject P1 = characterP1Prefabs[selectedP1Character];
        GameObject P2 = characterP2Prefabs[selectedP2Character];

        GameObject CloneP1 = Instantiate(P1, P1spawnPoint.position, Quaternion.identity);
        GameObject CloneP2 = Instantiate(P2, P2spawnPoint.position, Quaternion.identity);
    }
}
