using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectLoc : MonoBehaviour
{
    public GameObject[] mygem;
    public GameObject[] gemLoc;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<gemLoc.Length; i++)
        {
             //HingeJoint hinge = otherGameObject.GetComponent<HingeJoint>();
            var pos = new Vector3 (gemLoc[i].transform.position.x, gemLoc[i].transform.position.y, gemLoc[i].transform.position.z );
            //var pos = new Vector3 (gemLoc[i].GetComponent<Transform.Position>());//  .Transform.position);
            //(Random.Range(-6.0f, 4.0f), Random.Range(0.0f, 5.0f), Random.Range(-6.0f, 5.0f));
            Quaternion rot = Quaternion.Euler(270, 0, 0);
            int myO = Random.Range(0, mygem.Length);
            Instantiate(mygem[myO], pos, rot);
        }

        PlayerPrefs.SetInt("TotalGems", gemLoc.Length+1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
