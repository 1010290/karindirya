using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameScript : MonoBehaviour
{
    public void QuitGame() {
        Application.Quit();
        Debug.Log("Game Closes"); //ONLY FOR CHECKING PURPOSES
    }
}
