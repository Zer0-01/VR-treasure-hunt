using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject gem;
    //public int[] numbers;
    public int numGem;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i=0; i<numGem; i++)
        {
            var pos = new Vector3(Random.Range(-6.0f, 4.0f), Random.Range(0.0f, 5.0f), Random.Range(-6.0f, 5.0f));
            Quaternion rot = Quaternion.Euler(270, 0, 0);
            Instantiate(gem, pos, rot);
        }

        PlayerPrefs.SetInt("TotalGems", numGem);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
