using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterScript : MonoBehaviour
{
    public TMP_Text counterText;
    private int counter = 0;

    void Start()
    {
        counter = 0;
        UpdateCounterText();
    }

    public void IncrementCounter()
    {
        counter++;
        UpdateCounterText();
    }

    private void UpdateCounterText()
    {
        counterText.text = counter.ToString();
    }
}