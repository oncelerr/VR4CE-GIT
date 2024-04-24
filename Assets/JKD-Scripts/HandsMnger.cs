using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HandsMnger : MonoBehaviour
{
    public static bool HodingHoseNozzle = false;
    private bool isUsingRightHand;

    private void Start() 
    {
        isUsingRightHand = false;
    }

    // Checking if any hand is still holding the hose nozzle
    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.CompareTag("hoseNozzle"))
        {
            HodingHoseNozzle = true;
            
        }

        // Check if the player is holding the test tube
        if(GameMngr.CurrentLevelIndex == 3)
        {
            if(other.gameObject.CompareTag("testtube")) 
            {   
                if(isUsingRightHand) 
                {   
                    s3TestTubeContent.testtubeHoldingByHuman = true;
                }
            }
            else
            {
                s3TestTubeContent.testtubeHoldingByHuman = false;
            }
        }
    }

    // Checking if any hand is not holding the hose nozzle anymore
    private void OnTriggerExit(Collider other) 
    {
        HodingHoseNozzle = false;
    }

    public void TestTubeRightHandActivate(bool righHand)
    {
        if(righHand) 
        {
            isUsingRightHand = true;
        }
        else
        {
            isUsingRightHand = false;
        }
    }
}
