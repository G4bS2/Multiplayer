using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleLauncher : MonoBehaviourPunCallbacks
{
    public PhotonView playerPrefab;

    public InputField playerNickName;
    public GameObject nickNameInput;

     void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined a room");
        PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
    }

    public void StartTheGame()
    {
        PhotonNetwork.NickName = playerNickName.text;
        PhotonNetwork.ConnectUsingSettings();

        nickNameInput.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
