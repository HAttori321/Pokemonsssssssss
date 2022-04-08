using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;

    void Start()
    {
        PhotonNetwork.NickName = "Player_" + this.GetHashCode();
        Log("That`s your name - "+PhotonNetwork.NickName);

        PhotonNetwork.GameVersion = "1.0";
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Log("Connected to master successfully");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(null);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnJoinedRoom()
    {
        //GameObject entity=PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
        //Camera.main.GetComponent<CameraController>().playerTransform = entity.transform;
    }
    public void Log(string message)
    {
        Debug.Log(message);
    }

    void Update()
    {
        
    }
}
