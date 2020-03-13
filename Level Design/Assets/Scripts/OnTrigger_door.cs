using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_door : MonoBehaviour
{
    private Animator doorAnim;
    public GameObject toTrigger;
    private void OnTriggerEnter(Collider toTrigger)
    {
        doorAnim.SetBool("Open", true);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
