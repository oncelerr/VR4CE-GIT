using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using DG.Tweening;


public class S3ValveHose : MonoBehaviour
{
    public S3Burner _S3Burner;
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

        if(knob.value > 0.18f && !alreadySetValve2)
        {
            alreadySetValve2 = true;
            S3ValveTurnedON = true;
            GameMngr.S3currentsteps = 6;
            vrRobot.currentStepExecuted3 = false;
            // Get the current main module of the particle system
            var mainModule = _S3Burner.s3BurnerFire.main;

            // Decrease the start lifetime by the specified amount
            mainModule.startLifetime = Mathf.Max(mainModule.startLifetime.constant + S3Burner.s3BurnerFireAmount, 0f);
            Debug.Log("Valve 2 set ON!");
        }
    }
}
