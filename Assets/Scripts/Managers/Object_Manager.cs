﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object_Manager : singleton<Object_Manager>
{
    [SerializeField]
    GameObject model;
    [SerializeField]
    GameObject keyFeatureButtons;

    //Getting a call to the ui manager (upon awake we will ensure it is assigned)
    [SerializeField]
    UI_Manager ui;

    private void Awake()
    {
        //if the ui manager is unasigned
        if (ui == null)
        {
            //We can get it by type as there is only 1 UI manager in the scene
            ui = FindObjectOfType<UI_Manager>();
        }
    }
    void Update()
    {
        //Transform the rotation of both the 3D model and its buttons.
        model.transform.rotation = Quaternion.Euler(0f, ui.GetSlider().value, 0f);
        keyFeatureButtons.transform.rotation = Quaternion.Euler (90, ui.GetSlider().value, 0);
    }
}
