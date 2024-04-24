using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppeRoom : MonoBehaviour
{
    [SerializeField] AudioMngr _AudioMngr;

    private void Start() 
    {
        _AudioMngr.PlayBGMusic(_AudioMngr.bgMusic[0],true);
    }
    // private void OnTriggerEnter(Collider other) 
    // {
    //     if (other.gameObject.CompareTag("Human"))
    //     {
    //         _AudioMngr.PlayBGMusic(_AudioMngr.bgMusic[0],true);
    //         _AudioMngr.PlayBGMusic(_AudioMngr.bgMusic[1],false);
    //     }
    // }
    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.CompareTag("Human"))
        {
            _AudioMngr.PlayBGMusic(_AudioMngr.bgMusic[0],false);
            _AudioMngr.PlayBGMusic(_AudioMngr.bgMusic[1],true);
        }
    }
}
