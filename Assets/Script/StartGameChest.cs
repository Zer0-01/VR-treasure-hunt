using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGameChest : MonoBehaviour
{
    public TMP_Text chScore;
   
    void Start()
    {
        PlayerPrefs.SetInt("chScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
            chScore.text = "Score : " + PlayerPrefs.GetInt("chScore");
    }
}
