﻿using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        float rayDistance;

        //Debug make the ray visible
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 2;
        Debug.DrawRay(transform.position,forward,Color.red);

        if (Physics.Raycast(transform.position, (forward), out hit))
        {
            rayDistance = hit.distance;
            print(rayDistance + " " + hit.collider.gameObject.name);
        }

        if(Physics.Raycast(forward, out hit, rayDistance))
        {

        }
    }
}
