using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform me;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = me.position + offset;      
        
    }
    
    public void Camera_Follow()
    {
        Singleton.Instance.Camera_Follow();
    }

}
