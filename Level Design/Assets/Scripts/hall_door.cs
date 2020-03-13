using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hall_door : MonoBehaviour
{

    public Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("OpenDoor");   
    }

    void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("CloseDoor");
    }

    private void OnTriggerStay(Collider other)
    {
        anim.SetTrigger("PauseOpen");
    } 
}