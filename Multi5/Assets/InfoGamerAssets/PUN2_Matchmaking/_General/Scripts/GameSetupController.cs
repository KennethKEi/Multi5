using Photon.Pun;
using System.IO;
using UnityEngine;

public class GameSetupController : MonoBehaviour
{
 

    public Camera myCamera;
    public AudioListener myAL;

    public GameObject spawnPoint_Blue;
    public GameObject spawnPoint_Red;
    public GameObject spawnPoint_Yellow;

    public Vector3 sp_Blue;
    public Vector3 sp_Red;
    public Vector3 sp_Yellow;

    
    // This script will be added to any multiplayer scene
    void Start()
    {
        sp_Blue = spawnPoint_Blue.transform.position;
        sp_Red = spawnPoint_Red.transform.position;
        sp_Yellow = spawnPoint_Yellow.transform.position;

        CreatePlayer(); //Create a networked player object for each player that loads into the multiplayer scenes.
    }

    private void CreatePlayer()
    {
        Debug.Log("Creating Player");

        if (CharacterSelection.CS.myCharacter == 0)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer_Blue"), sp_Blue, Quaternion.identity);
        }
        else if (CharacterSelection.CS.myCharacter == 1)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer_Red"), sp_Red, Quaternion.identity);
        }
        else if (CharacterSelection.CS.myCharacter == 2)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer_Yellow"), sp_Yellow, Quaternion.identity);
        }
        //0 = Blue
        //1 = Red
        //2 = Yellow
    }
}
