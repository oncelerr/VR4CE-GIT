using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using DG.Tweening;


public class s3TestTubeHolder : MonoBehaviour
{
    private bool _testtubeSnapperDone;

    private void Start() 
    {
        _testtubeSnapperDone = false;
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("testtube"))
        {
            if(!_testtubeSnapperDone)
            {
                _testtubeSnapperDone = true;
                GameMngr.S3currentsteps = 3;
                vrRobot.currentStepExecuted3 = false;
                Debug.Log("Test tube already set.");
            }
        }
    }
}
