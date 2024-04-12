using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s3TestTubeContent : MonoBehaviour
{
    public GameObject[] testtubeObj;
    public static float s3testtubeAmount;
    private bool success = false;
    private int whichtestubeisHolding; // variable for checking if the player holds the tube


    // Ferrous transfer success variables
    public static bool FerrousTransferSuccess;

    private void Start() 
    {
        // Initialize variables
        success = false;
        s3testtubeAmount = 0f;
    }
    void Update()
    {
        CheckFerrousTransferStatus();

        // Check what test tube is holding
        if(whichtestubeisHolding == 1)
        {
            UpdateFerrousContent(testtubeObj[whichtestubeisHolding]);
        }
        else if(whichtestubeisHolding == 2)
        {
            UpdateFerrousContent(testtubeObj[whichtestubeisHolding]);
        }
        else if(whichtestubeisHolding == 3)
        {
            UpdateFerrousContent(testtubeObj[whichtestubeisHolding]);
        }
        else if(whichtestubeisHolding == 4)
        {
            UpdateFerrousContent(testtubeObj[whichtestubeisHolding]);
        }
        
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
        if(tube == 1)
        {
            whichtestubeisHolding = tube;
        }
        else if(tube == 2)
        {
            whichtestubeisHolding = tube;
        }
        else if(tube == 3)
        {
            whichtestubeisHolding = tube;
        }
        else if(tube == 4)
        {
            whichtestubeisHolding = tube;
        }
    }

    private void CheckFerrousTransferStatus()  //THis checks if the ferrous liquid is transfered succesfully
    {
        if(s3testtubeAmount >= 0.5f && !success)
        {
            success = true;
            FerrousTransferSuccess = true;
            Debug.Log("Ferrous sulfate transfer success!");
        }
    }
}
