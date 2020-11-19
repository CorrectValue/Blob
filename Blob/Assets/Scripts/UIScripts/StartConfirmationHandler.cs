using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartConfirmationHandler : MonoBehaviour
{
    //This script is necessary to pass data from the main menu into the main scene and start the game.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void handle()
    {
        //acts when the button is pressed
        nextScene();
    }

    private void nextScene()
    {
        SceneManager.LoadScene("Scenes/scene");
    }
}
