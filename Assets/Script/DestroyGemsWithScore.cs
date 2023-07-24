using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGemsWithScore : MonoBehaviour
{
    public int score; 
    public GameObject letup;
    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
 
    public void destroyMe()
    {
        int Addscore = PlayerPrefs.GetInt("cScore");
        int Tgems = PlayerPrefs.GetInt("TotalGems");
        PlayerPrefs.SetInt("cScore", Addscore + score);
        PlayerPrefs.SetInt("TotalGems", Tgems - 1);
        letup.SetActive(true);

        
        if (meshRenderer != null)
        {
            Destroy(meshRenderer);
        }
        Destroy(this.gameObject, 3.0f);
    }
}
