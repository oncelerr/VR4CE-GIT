using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftPlateTrigger : MonoBehaviour
{
    public float leftPlateWeight;

    public triggerZoneManager triggerZoneManager;

    private void OnTriggerEnter(Collider other)
    {
        //first question
        if (other.CompareTag("CO2_molecule"))
        {
            leftPlateWeight = leftPlateWeight + 4;
            triggerZoneManager.firstQuestion();
        }
        //second question
        if (other.CompareTag("NO2_molecule"))
        {
            leftPlateWeight = leftPlateWeight + 4;
            triggerZoneManager.secondQuestion();
        }
        //third question
        if (other.CompareTag("NH3_molecule"))
        {
            leftPlateWeight = leftPlateWeight + 5;
            triggerZoneManager.thirdQuestion();
        }
        //fourth question
        if (other.CompareTag("H2O_molecule"))
        {
            leftPlateWeight = leftPlateWeight + 8;
            triggerZoneManager.fourthQuestion();
        }
        if (other.CompareTag("C_molecule"))
        {
            leftPlateWeight = leftPlateWeight + 1;
            triggerZoneManager.fourthQuestion();
        }
        //fifth question
        if (other.CompareTag("CS2_molecule"))
        {
            leftPlateWeight = leftPlateWeight + 5;
            triggerZoneManager.fifthQuestion();
        }
        if (other.CompareTag("O2_molecule"))
        {
            leftPlateWeight = leftPlateWeight + 6;
            triggerZoneManager.fifthQuestion();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //first question
        if (other.CompareTag("CO2_molecule"))
        {
            leftPlateWeight = leftPlateWeight - 4;
            triggerZoneManager.firstQuestion();
        }
        //second question
        if (other.CompareTag("NO2_molecule"))
        {
            leftPlateWeight = leftPlateWeight - 4;
            triggerZoneManager.secondQuestion();
        }
        //third question
        if (other.CompareTag("NH3_molecule"))
        {
            leftPlateWeight = leftPlateWeight - 5;
            triggerZoneManager.thirdQuestion();
        }
        //fourth question
        if (other.CompareTag("H2O_molecule"))
        {
            leftPlateWeight = leftPlateWeight - 8;
            triggerZoneManager.fourthQuestion();
        }
        if (other.CompareTag("C_molecule"))
        {
            leftPlateWeight = leftPlateWeight - 1;
            triggerZoneManager.fourthQuestion();
        }
        //fifth question
        if (other.CompareTag("CS2_molecule"))
        {
            leftPlateWeight = leftPlateWeight - 5;
            triggerZoneManager.fifthQuestion();
        }
        if (other.CompareTag("O2_molecule"))
        {
            leftPlateWeight = leftPlateWeight - 6;
            triggerZoneManager.fifthQuestion();
        }
    }
}

