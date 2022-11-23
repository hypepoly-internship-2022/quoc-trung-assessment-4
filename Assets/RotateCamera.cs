using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    float horizontalSpeed = 1.0f;
    float yaw = 0.0f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            yaw += horizontalSpeed * Input.GetAxis("Mouse X");
            yaw = Mathf.Clamp(yaw, -40f, 40f);
            transform.eulerAngles = new Vector3(0, -yaw, 0);
        }
    }
}
