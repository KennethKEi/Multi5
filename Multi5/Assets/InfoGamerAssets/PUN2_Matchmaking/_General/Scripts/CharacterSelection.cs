using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{

    public static CharacterSelection CS;
    public int myCharacter;

    private void OnEnable()
    {
        if(CharacterSelection.CS ==null)
        {
            CharacterSelection.CS = this;
        }
        else
        {
            if(CharacterSelection.CS !=this)
            {
                Destroy(CharacterSelection.CS.gameObject);
                CharacterSelection.CS = this;
            }
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void BlueCharacter()
    {
        myCharacter = 0;
        Debug.Log("myCharacter is " + myCharacter);
    }
    public void RedCharacter()
    {
        myCharacter = 1;
        Debug.Log("myCharacter is " + myCharacter);
    }
    public void YellowCharacter()
    {
        myCharacter = 3;
        Debug.Log("myCharacter is " + myCharacter);
    }
    
}
