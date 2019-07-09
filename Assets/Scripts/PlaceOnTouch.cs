using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class PlaceOnTouch : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Prefab I want to instantiate")]
    GameObject prefabToPlace;

    //A list of hit locations that we will call upon.
    static List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    //Make a reference to the RaycastManger (On AR Session Origin Prefab)
    public ARRaycastManager raycastManager;


    // A container to hold the spawned object
    public GameObject spawnedObject;

    void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    //function returning a bool, checking if we can get the position based on touch.
    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }

    void Update()
    {
        //If we cant touch then return out of the loop.
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;

        //check if the raycast hit any plane with polygons
        if (raycastManager.Raycast(touchPosition, raycastHits, TrackableType.PlaneWithinPolygon))
        {
            // Raycast hits are sorted by distance, so the first is closest
            var hitPose = raycastHits[0].pose;

            if (spawnedObject == null)
            {
                spawnedObject = Instantiate(prefabToPlace, hitPose.position, hitPose.rotation);
            }
        }
    }
}
