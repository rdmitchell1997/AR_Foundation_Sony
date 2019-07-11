using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Look_At : MonoBehaviour
{
    private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        if (camera == null)
        {
            camera = GameObject.FindWithTag("MainCamera");
        }
    }

    // Update is called once per frame
    void Update()
    {
       transform.LookAt(camera.transform); 
    }
}
