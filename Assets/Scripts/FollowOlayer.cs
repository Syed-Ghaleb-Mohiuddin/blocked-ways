using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOlayer : MonoBehaviour
{
    private Transform player;
   // public Vector3 offset;
    void Start()
    {
      
        player = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<Transform>();

        //offset = new Vector3(0, 4, -10);
    }
    void Update()
    {
        //transform.position = player.position + offset;
        transform.position = player.position + new Vector3(0, 4, -10);

    }
}
