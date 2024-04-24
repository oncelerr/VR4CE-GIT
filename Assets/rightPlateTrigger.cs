using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightPlateTrigger : MonoBehaviour
{
    public triggerZoneManager triggerZoneManager;

    public float rightPlateWeight;
    private void OnTriggerEnter(Collider other)
    {
        //first question
        if (other.CompareTag("O2_molecule"))
        {
            rightPlateWeight = rightPlateWeight + 2;
            triggerZoneManager.firstQuestion();
        }
        if (other.CompareTag("CO_molecule"))
        {
            rightPlateWeight = rightPlateWeight + 3;
            triggerZoneManager.firstQuestion();
        }
        //second question
        if (other.CompareTag("NO_molecule"))
        {
            rightPlateWeight = rightPlateWeight + 3;
            triggerZoneManager.secondQuestion();
        }
        if (other.CompareTag("O2_molecule1"))
        {
            rightPlateWeight = rightPlateWeight + 2;
            triggerZoneManager.secondQuestion();
        }
        //third question
        if (other.CompareTag("N2_molecule"))
        {
            rightPlateWeight = rightPlateWeight + 4;
            triggerZoneManager.thirdQuestion();
        }
        if (other.CompareTag("H2_molecule"))
        {
            rightPlateWeight = rightPlateWeight + 2;
            triggerZoneManager.thirdQuestion();
        }
        //fourth question
        if (other.CompareTag("CH4_molecule"))
        {
            rightPlateWeight = rightPlateWeight + 13;
            triggerZoneManager.fourthQuestion();
        }
        if (other.CompareTag("CO2_molecule"))
        {
            rightPlateWeight = rightPlateWeight + 5;
            triggerZoneManager.fourthQuestion();
        }
        //fifth question
        if (other.CompareTag("CO2_molecule"))
        {
            rightPlateWeight = rightPlateWeight + 7;
            triggerZoneManager.fifthQuestion();
        }
        if (other.CompareTag("SO2_molecule"))
        {
            rightPlateWeight = rightPlateWeight + 8;
            triggerZoneManager.fifthQuestion();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //first question
        if (other.CompareTag("O2_molecule"))
        {
            rightPlateWeight = rightPlateWeight - 2;
            triggerZoneManager.firstQuestion();
        }
        if (other.CompareTag("CO_molecule"))
        {
            rightPlateWeight = rightPlateWeight - 3;
            triggerZoneManager.firstQuestion();
        }
        //second question
        if (other.CompareTag("NO_molecule"))
        {
            rightPlateWeight = rightPlateWeight - 3;
            triggerZoneManager.secondQuestion();
        }
        if (other.CompareTag("O2_molecule1"))
        {
            rightPlateWeight = rightPlateWeight - 2;
            triggerZoneManager.secondQuestion();
        }
        //third question
        if (other.CompareTag("N2_molecule"))
        {
            rightPlateWeight = rightPlateWeight - 4;
            triggerZoneManager.thirdQuestion();
        }
        if (other.CompareTag("H2_molecule"))
        {
            rightPlateWeight = rightPlateWeight - 2;
            triggerZoneManager.thirdQuestion();
        }
        //fourth question
        if (other.CompareTag("CH4_molecule"))
        {
            rightPlateWeight = rightPlateWeight - 13;
            triggerZoneManager.fourthQuestion();
        }
        if (other.CompareTag("CO2_molecule"))
        {
            rightPlateWeight = rightPlateWeight - 5;
            triggerZoneManager.fourthQuestion();
        }
        //fifth question
        if (other.CompareTag("CO2_molecule"))
        {
            rightPlateWeight = rightPlateWeight - 7;
            triggerZoneManager.fifthQuestion();
        }
        if (other.CompareTag("SO2_molecule"))
        {
            rightPlateWeight = rightPlateWeight - 8;
            triggerZoneManager.fifthQuestion();
        }
    }
}
