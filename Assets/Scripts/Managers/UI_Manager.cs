using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : singleton<UI_Manager>
{
    [SerializeField]
    GameObject[] keyFeaturesList;

    [SerializeField]
    GameObject videoScreen;

    [SerializeField]
    Slider rotationSlider;

    private void Awake()
    {
        //If the video is unassigned
        if (videoScreen == null)
        {
            //find the tagged object.
            videoScreen = GameObject.FindGameObjectWithTag("Video");
        }
    }
    //Getter allows to objects fields to be accesed by other scripts without changing them.
    public Slider GetSlider()
    {
        return rotationSlider;
    }

    //Show the video player.
    public void ShowVideo()
    {
        videoScreen.SetActive(true);
    }

    //A function that needs to be passed a number that fits the desired gameobject.
    //We first ensure all previous key features are disabled then only enable the new one.
    public void ShowKeyFeature(int arrayNumber)
    {
        foreach (GameObject item in keyFeaturesList)
        {
            item.SetActive(false);
        }
        keyFeaturesList[arrayNumber].SetActive(true);
    }

    //Opens the product website on the users device.
    //May want to add check here to ensure the user wants to be directed away from the app.
    public void ShowWebsite()
    {
        Application.OpenURL("https://www.sony.co.uk/electronics/headband-headphones/wh-h900n");
    }
}
