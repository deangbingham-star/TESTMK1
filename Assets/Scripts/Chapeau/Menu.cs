using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;


public class Menu : MonoBehaviourPunCallbacks
{

    [Header("Screens")]
    public GameObject mainScreen;
    public GameObject lobbyScreen;

    [Header("MainScreen")]
    public Button createRoomButton;
    public Button joinRoomButton;

    [Header("Lobby Screen")]
    public TextMeshProUGUI playerListText;
    public Button startGameButton;


    void Start()
    {
        // disable buttons at start if not connected to server 
        createRoomButton.interactable = false;
        joinRoomButton.interactable = false;

    }

    // enables "Create Room" and "Join Room" 
    public override void OnConnectedToMaster()
    {
        createRoomButton.interactable = true;
        joinRoomButton.interactable = true;
    }

}