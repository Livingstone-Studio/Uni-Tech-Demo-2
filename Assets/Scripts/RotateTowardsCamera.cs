using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (!Camera.main) return;
        if (!Camera.main.enabled) return;

        transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward, Camera.main.transform.up);
    }
}