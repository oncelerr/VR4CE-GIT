using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class S3Burner : MonoBehaviour
{
    private bool s3burnAlreadyIgnited;
    [SerializeField] ParticleSystem s3Burner;

    private void Start() 
    {
        s3burnAlreadyIgnited = false;
        s3Burner.Stop();
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("lighter"))
        {
            if(!s3burnAlreadyIgnited)
            {
                s3burnAlreadyIgnited = true;
                s3Burner.Play();
                GameMngr.S3currentsteps = 5;
                vrRobot.currentStepExecuted3 = false;
                Debug.Log("Burner is on.");
            }
        }
    }
}
