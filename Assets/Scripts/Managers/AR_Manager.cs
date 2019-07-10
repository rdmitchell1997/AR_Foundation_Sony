using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

//I employ a singleton code pattern to ensure only 1 AR_manager is ever present in the scene.
public class AR_Manager : singleton<AR_Manager>
{
    //These are private objects we will assign the prefabs to in editor to instatiate them upon startup.
    [Header("AR Prefabs")]
    [SerializeField]
    private GameObject arPlane;
    [SerializeField]
    private GameObject arPointCloud;
    [SerializeField]
    private GameObject arSessionOrigin;

    //Upon Awake (Before Start) we will instantiate each object.
    void Awake()
    {
        Instantiate(arPlane, transform.position, transform.rotation);
        Instantiate(arPointCloud, transform.position, transform.rotation);
        Instantiate(arSessionOrigin, transform.position, transform.rotation);
    }
}
