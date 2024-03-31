using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftPlateTrigger : MonoBehaviour
{
    public int leftPlateWeight;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("molecule"))
        {
            leftPlateWeight++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("molecule"))
        {
            leftPlateWeight--;
        }
    }
}

