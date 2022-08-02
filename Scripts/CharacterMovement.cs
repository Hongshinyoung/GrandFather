using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 20;
    float hAxis;
    float vAxis;

    Vector3 MoveVector;

    Animator anim;


    void Update()
    {
        hAxis = Input.GetAxisRaw("Horiziontal");
        vAxis = Input.GetAxisRaw("Vertical");
    }

    void Awake()
    {
        
    }
}
