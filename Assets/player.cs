using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class player : MonoBehaviourPun
{
    GameObject character;
    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();

        if (view.IsMine)
        {
            // Instantiate the player's avatar prefab for the local player
            character = PhotonNetwork.Instantiate("avatar 1", transform.position, transform.rotation, 0);

            // Instantiate the player's camera prefab for the local player
            GameObject cameraPrefab = Resources.Load("Assets/Players/MainCamera") as GameObject;
            GameObject mainCamera = Instantiate(cameraPrefab, transform.position, transform.rotation);
            mainCamera.tag = "MainCamera";
            mainCamera.GetComponent<Camera>().enabled = true;
            mainCamera.GetComponent<AudioListener>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
