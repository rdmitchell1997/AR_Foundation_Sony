using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object_Manager : singleton<Object_Manager>
{
    public GameObject model;
    public Slider rotationSlider;

    void Update()
    {
        model.transform.rotation = Quaternion.Euler (0f, rotationSlider.value, 0f);
    }
}
