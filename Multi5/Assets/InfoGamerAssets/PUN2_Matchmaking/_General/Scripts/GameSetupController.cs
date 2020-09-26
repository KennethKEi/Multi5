using Photon.Pun;
using System.IO;
using UnityEngine;

public class GameSetupController : MonoBehaviour
{
 

    public Camera myCamera;
    public AudioListener myAL;


    // This script will be added to any multiplayer scene
    void Start()
    {
        
        CreatePlayer(); //Create a networked player object for each player that loads into the multiplayer scenes.
    }

    private void CreatePlayer()
    {
        Debug.Log("Creating Player");

        if (CharacterSelection.CS.myCharacter == 0)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer_Blue"), Vector3.zero, Quaternion.identity);
        }
        else if (CharacterSelection.CS.myCharacter == 1)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer_Red"), Vector3.zero, Quaternion.identity);
        }
        else if (CharacterSelection.CS.myCharacter == 2)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer_Yellow"), Vector3.zero, Quaternion.identity);
        }
    }
}
