using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    void Start()
    {
        
    }

    void Update()
    {
        if (playerTransform != null)
        {
            Vector3 vector3 = new Vector3(playerTransform.position.x, playerTransform.position.y, this.transform.position.z);
            this.transform.position = vector3;
        }
    }
}
