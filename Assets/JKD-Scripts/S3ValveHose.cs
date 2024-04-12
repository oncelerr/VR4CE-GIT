using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using DG.Tweening;


public class S3ValveHose : MonoBehaviour
{
    public XRKnob knob;
    private bool alreadySetValve;
    public static bool S3ValveTurnedON;

    private void Start() 
    {
        // Reset variables
        alreadySetValve = false;
        S3ValveTurnedON = false;
    }
    void Update()
    {
        if(knob.value >= 0 && !alreadySetValve)
        {
            alreadySetValve = true;
            S3ValveTurnedON = true;
        }
    }
}
