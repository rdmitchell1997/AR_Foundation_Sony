using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : singleton<UI_Manager>
{

    public GameObject videoScreen;

    public void ShowVideo()
    {
        videoScreen.SetActive(true);
    }
}
