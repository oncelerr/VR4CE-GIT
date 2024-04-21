using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class s3TestTubeContent : MonoBehaviour
{
    public GameObject[] testtubeObj;
    public static float s3testtubeAmount;
    private bool success;
    private bool step1Triggered;
    public static int whichtestubeisHolding = 0; // variable for checking if the player holds the tube
    public static bool testtubeHoldingByHuman;
    // Ferrous transfer success variables
    public static bool FerrousTransferSuccess;

    private void OnEnable() 
    {
        // Initialize variables
        step1Triggered = false;
        success = false;
        s3testtubeAmount = 0f;
        whichtestubeisHolding = 0;
    }
    
    private void Update()
    {
        CheckFerrousTransferStatus();
        UpdateFerrousContent(testtubeObj[whichtestubeisHolding]);
    }
 
    private void UpdateFerrousContent(GameObject tube) 
    {
        if(GameMngr.CurrentLevelIndex == 3)
        {
            
            // Debug.Log("Iodine in the IB: " +s3testtubeAmount);
            // Debug.Log("Iodine in the EB: " +mixingBeakerContent.iodineValue);
            
            // Get the Renderer component of the GameObject
            Renderer tubeRenderer = tube.GetComponent<Renderer>();

            // Get the material of the Renderer
            Material material = tubeRenderer.material;

            // Check if the material has a "_Fill" property
            if (material.HasProperty("_Fill"))
            {
                // Get the current fill value from the material
                float fillValue = material.GetFloat("_Fill");

                // Equate to static variable na connected sa beaker
                fillValue = s3testtubeAmount;

                // Clamp the fill value to stay within the range 0 to 1
                fillValue = Mathf.Clamp01(fillValue);

                // Set the fill value in the material
                material.SetFloat("_Fill", fillValue);

                // Debug.Log("Iodine Current Fill Value: " + fillValue);

            }
            else
            {
                Debug.LogError("Iodine Material does not have a _Fill property");
            }
        }
    }
    public void WhichTestTube(int tube)
    {
        if(testtubeHoldingByHuman)
        {
            if(tube == 1) 
            {
                whichtestubeisHolding = tube;
                if(!step1Triggered)
                {   
                    step1Triggered = true;
                    GameMngr.S3currentsteps = 1;
                    vrRobot.currentStepExecuted3 = false;
                }
                Debug.Log("Player chose test tube "+whichtestubeisHolding);
            }
            if(tube == 2) 
            {
                whichtestubeisHolding = tube;
                if(!step1Triggered)
                {   
                    step1Triggered = true;
                    GameMngr.S3currentsteps = 1;
                    vrRobot.currentStepExecuted3 = false;
                }
                Debug.Log("Player chose test tube "+whichtestubeisHolding);
            }
            if(tube == 3) 
            {
                whichtestubeisHolding = tube;
                if(!step1Triggered)
                {   
                    step1Triggered = true;
                    GameMngr.S3currentsteps = 1;
                    vrRobot.currentStepExecuted3 = false;
                }
                Debug.Log("Player chose test tube "+whichtestubeisHolding);
            }
            if(tube == 4) 
            {
                whichtestubeisHolding = tube;
                if(!step1Triggered)
                {   
                    step1Triggered = true;
                    GameMngr.S3currentsteps = 1;
                    vrRobot.currentStepExecuted3 = false;
                }
                Debug.Log("Player chose test tube "+whichtestubeisHolding);
            }
        }
        else
        {
            whichtestubeisHolding = 0;
        }

        
    }

    private void CheckFerrousTransferStatus()  //THis checks if the ferrous liquid is transfered succesfully
    {
        if(s3testtubeAmount >= 0.5f && !success)
        {
            success = true;
            FerrousTransferSuccess = true;
            GameMngr.S3currentsteps = 2;
            vrRobot.currentStepExecuted3 = false;
            Debug.Log("Ferrous sulfate transfer success!");
        }
    }
}
