using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSFollowCar : MonoBehaviour
{
    public Transform target;
    public Transform MainCam;// Reference to the object to follow

    private float initialX;     // Initial X position of the camera
    private float initialY;

    float CamDIst;
    float SideDist;

    void Start()
    {
        // Store the camera's initial X and Y position
        initialX = transform.position.x;
        initialY = transform.position.y;
        CamDIst = -30f;
        SideDist = 0f;
    }

    void LateUpdate()
    {
        if (target != null) 
        {
            // Update only the Z position to follow the target
            transform.position = new Vector3(initialX+ SideDist, initialY, target.position.z + CamDIst);
            if (target.transform.position.z < -460f)
            {
               
                MainCam.rotation = Quaternion.Euler(0, 0, 0);
                CamDIst = -30f;
                SideDist = 20f;

            } 
            if (target.transform.position.z > 6410)
            {
              
                SideDist = 0f;
                MainCam.rotation = Quaternion.Euler(0, 180, 0);
                CamDIst = +30f;

            }
        }
    }
}
