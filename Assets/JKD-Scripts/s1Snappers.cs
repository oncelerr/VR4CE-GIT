using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1Snappers : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("hoseEnd1")) 
        {
            GameMngr.S1currentsteps = 1f;
        }
    }
}
