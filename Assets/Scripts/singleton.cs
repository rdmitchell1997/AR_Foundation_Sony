using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is a singleton class that will ensure only 1 instance of each desired class at a time.
public abstract class singleton<T> : MonoBehaviour where T : MonoBehaviour
{

    private static T instance;

    public static T Instance
    {
        get
        {
            //if there is no instance.
            if (instance == null)
            {
                //lets find and assign one.
                instance = FindObjectOfType<T>();
            }
            //else destroy the object and return the instance.
            DontDestroyOnLoad(instance);
            return instance;
        }
    }
}