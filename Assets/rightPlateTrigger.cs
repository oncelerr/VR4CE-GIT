using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightPlateTrigger : MonoBehaviour
{
    public int rightPlateWeight;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("molecule"))
        {
            rightPlateWeight++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("molecule"))
        {
            rightPlateWeight--;
        }
    }
}
