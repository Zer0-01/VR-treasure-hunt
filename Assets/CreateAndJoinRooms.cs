using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createinput;
    public InputField joininput;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createinput.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joininput.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
