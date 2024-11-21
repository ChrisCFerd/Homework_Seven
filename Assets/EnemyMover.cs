using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    void Start()
    {
        StartCoroutine(FollowPath());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FollowPath(){
        foreach(Waypoint waypoint in path){
            Vector3 startPosition = transform.position;
            Vector3 endPoisition = waypoint.transform.position; 
            float travelPercentage = 0;

            while(travelPercentage < 1f) {
                travelPercentage = travelPercentage + Time.deltaTime;
                transform.position = Vector3.Lerp(startPosition, endPoisition, travelPercentage);
                yield return new WaitForEndOfFrame();

        }

        }
    }
}
