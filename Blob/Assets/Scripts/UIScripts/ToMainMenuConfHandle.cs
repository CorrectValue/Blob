using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToMainMenuConfHandle : MonoBehaviour
{

    public void handle()
    {
        //acts when the button is pressed
        nextScene();
    }

    private void nextScene()
    {
        //switches between scenes
        SceneManager.LoadScene("Scenes/MainMenu");
    }
}
