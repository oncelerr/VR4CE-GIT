using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using DG.Tweening;


public class S3ValveHose : MonoBehaviour
{
    public XRKnob knob;
    private bool alreadySetValve;
    private bool alreadySetValve2;
    public static bool S3ValveTurnedON;

    private void Start() 
    {
        // Reset variables
        alreadySetValve = false;
        alreadySetValve2 = false;
        S3ValveTurnedON = false;
    }
    void Update()
    {
        if(knob.value > 0 && knob.value < 0.15f && !alreadySetValve)
        {
            alreadySetValve = true;
            S3ValveTurnedON = true;
            GameMngr.S3currentsteps = 4;
            vrRobot.currentStepExecuted3 = false;
            Debug.Log("Valve turned ON!");
        }

        if(knob.value > 0.16f && !alreadySetValve2)
        {
            alreadySetValve2 = true;
            S3ValveTurnedON = true;
            GameMngr.S3currentsteps = 6;
            vrRobot.currentStepExecuted3 = false;
            Debug.Log("Valve turned ON!");
        }
    }
}
