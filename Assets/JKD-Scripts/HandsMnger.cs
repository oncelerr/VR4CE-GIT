using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HandsMnger : MonoBehaviour
{
    public static bool HodingHoseNozzle = false;


    // Checking if any hand is still holding the hose nozzle
    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.CompareTag("hoseNozzle"))
        {
            HodingHoseNozzle = true;
        }
    }

    // Checking if any hand is not holding the hose nozzle anymore
    private void OnTriggerExit(Collider other) 
    {
        HodingHoseNozzle = false;
    }
}
