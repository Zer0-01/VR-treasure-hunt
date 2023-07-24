using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChestWithScore : MonoBehaviour
{
    public int score;
    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
 
    public void destroyMePls()
    {
        int Addscore = PlayerPrefs.GetInt("chScore");
        PlayerPrefs.SetInt("chScore", Addscore + score);

        
        if (meshRenderer != null)
        {
            Destroy(meshRenderer);
        }
        Destroy(this.gameObject, 0.0f);
    }
}
