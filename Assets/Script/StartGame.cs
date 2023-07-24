using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{
    public TMP_Text cScore;
    public TMP_Text bScore;
    public TMP_Text ttGems;
   
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        PlayerPrefs.SetInt("cScore", 0);
        
    }

    // Update is called once per frame
    void Update()
    {
            cScore.text = "Score : " + PlayerPrefs.GetInt("cScore");
            if (PlayerPrefs.GetInt("cScore") > PlayerPrefs.GetInt("bScore"))
            {
                PlayerPrefs.SetInt("bScore", PlayerPrefs.GetInt("cScore") );
            }
            bScore.text = "Best Score : " + PlayerPrefs.GetInt("bScore");
            ttGems.text = "Gems : "+ PlayerPrefs.GetInt("TotalGems"); 
    }
}
