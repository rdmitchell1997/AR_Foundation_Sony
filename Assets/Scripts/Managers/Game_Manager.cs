using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : singleton<Game_Manager>
{
    public void RestartScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
