using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup_Canvas : MonoBehaviour
{
    //This Script will count down 5 seconds after which time the startup canvas will be destroyed.

    float secsLeft = 5;

    // Update is called once per frame
    void Update()
    {
        secsLeft -= Time.deltaTime;

        if(secsLeft <= 0)
        {
            Destroy(gameObject);
        }
    }
}
