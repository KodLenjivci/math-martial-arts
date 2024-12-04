using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr1;
    public Animator a1;
    public List<Sprite> skins1 = new List<Sprite>();
    public List<RuntimeAnimatorController> anims1 = new List<RuntimeAnimatorController>();
    private int selectedSkin1 = 0;
    public GameObject playerSkin1;

    public SpriteRenderer sr2;
    public Animator a2;
    public List<Sprite> skins2 = new List<Sprite>();
    public List<RuntimeAnimatorController> anims2 = new List<RuntimeAnimatorController>();
    private int selectedSkin2 = 0;
    public GameObject playerSkin2;

    public void NextOptionP1()
    {
        selectedSkin1 += 1;
        if (selectedSkin1==skins1.Count)
        {
            selectedSkin1 = 0;
        }
        sr1.sprite = skins1[selectedSkin1];
        a1.runtimeAnimatorController = anims1[selectedSkin1];
    }
    public void BackOptionP1()
    {
        selectedSkin1 -= 1;
        if (selectedSkin1 < 0)
        {
            selectedSkin1 = skins1.Count-1;
        }
        sr1.sprite = skins1[selectedSkin1];
        a1.runtimeAnimatorController = anims1[selectedSkin1];
    }


    public void NextOptionP2()
    {
        selectedSkin2 += 1;
        if (selectedSkin2 == skins2.Count)
        {
            selectedSkin2 = 0;
        }
        sr2.sprite = skins2[selectedSkin2];
        a2.runtimeAnimatorController = anims2[selectedSkin2];
    }
    public void BackOptionP2()
    {
        selectedSkin2 -= 1;
        if (selectedSkin2 < 0)
        {
            selectedSkin2 = skins2.Count - 1;
        }
        sr2.sprite = skins2[selectedSkin2];
        a2.runtimeAnimatorController = anims2[selectedSkin2];
    }



    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerSkin1, "Assets/P1selectedSkin.prefab");
        PrefabUtility.SaveAsPrefabAsset(playerSkin2, "Assets/P2selectedSkin.prefab");
        SceneManager.LoadScene("MainScene");
    }

}
