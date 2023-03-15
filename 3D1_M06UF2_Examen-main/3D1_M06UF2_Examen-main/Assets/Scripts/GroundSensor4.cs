using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor4 : MonoBehaviour
{
    BoxCollider2D boxcollider2D;
    public bool groundsensor;

    // Start is called before the first frame update
    void Awake()
    {
        boxcollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer ==3)
        groundsensor = true ;
    }

     void OnTriggerExit2D(Collider2D other)
    {
    
        if (other.gameObject.layer ==3)
        groundsensor = false ;
    }
    }
