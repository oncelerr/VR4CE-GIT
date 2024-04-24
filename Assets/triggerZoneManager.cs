using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using static PlaySteps;

public class triggerZoneManager : MonoBehaviour
{
    public rightPlateTrigger rightPlateTriggerScript;
    public leftPlateTrigger leftPlateTriggerScript;
    public PlaySteps playStepsScript;

    private bool isMoving = false;
    private float duration = 0.5f;

    public void firstQuestion()
    {
        GameObject sphere1 = GameObject.FindGameObjectWithTag("sphere1");
        GameObject sphere2 = GameObject.FindGameObjectWithTag("sphere2");

        if(rightPlateTriggerScript.rightPlateWeight == leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
        }
        if(rightPlateTriggerScript.rightPlateWeight < leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.331f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.427f, -5.216f))); 
        }
        if (rightPlateTriggerScript.rightPlateWeight > leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.427f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.331f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight == 8 && leftPlateTriggerScript.leftPlateWeight == 8)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
            playStepsScript.PlayStepIndex(10);
        }

        Debug.Log(rightPlateTriggerScript.rightPlateWeight);
        Debug.Log(leftPlateTriggerScript.leftPlateWeight);
    }
    public void secondQuestion()
    {
        GameObject sphere1 = GameObject.FindGameObjectWithTag("sphere1");
        GameObject sphere2 = GameObject.FindGameObjectWithTag("sphere2");

        if (rightPlateTriggerScript.rightPlateWeight == leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight < leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.331f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.427f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight > leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.427f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.331f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight == 16 && leftPlateTriggerScript.leftPlateWeight == 16)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
            playStepsScript.PlayStepIndex(11);
        }

        Debug.Log(rightPlateTriggerScript.rightPlateWeight);
        Debug.Log(leftPlateTriggerScript.leftPlateWeight);
    }

    public void thirdQuestion()
    {
        GameObject sphere1 = GameObject.FindGameObjectWithTag("sphere1");
        GameObject sphere2 = GameObject.FindGameObjectWithTag("sphere2");

        if (rightPlateTriggerScript.rightPlateWeight == leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight < leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.331f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.427f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight > leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.427f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.331f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight == 26 && leftPlateTriggerScript.leftPlateWeight == 26)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
            playStepsScript.PlayStepIndex(12);
        }

        Debug.Log(rightPlateTriggerScript.rightPlateWeight);
        Debug.Log(leftPlateTriggerScript.leftPlateWeight);
    }

    public void fourthQuestion()
    {
        GameObject sphere1 = GameObject.FindGameObjectWithTag("sphere1");
        GameObject sphere2 = GameObject.FindGameObjectWithTag("sphere2");

        if (rightPlateTriggerScript.rightPlateWeight == leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight < leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.331f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.427f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight > leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.427f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.331f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight == 44 && leftPlateTriggerScript.leftPlateWeight == 44)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
            playStepsScript.PlayStepIndex(13);
        }

        Debug.Log(rightPlateTriggerScript.rightPlateWeight);
        Debug.Log(leftPlateTriggerScript.leftPlateWeight);
    }

    public void fifthQuestion()
    {
        GameObject sphere1 = GameObject.FindGameObjectWithTag("sphere1");
        GameObject sphere2 = GameObject.FindGameObjectWithTag("sphere2");

        if (rightPlateTriggerScript.rightPlateWeight == leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight < leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.331f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.427f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight > leftPlateTriggerScript.leftPlateWeight)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.427f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.331f, -5.216f)));
        }
        if (rightPlateTriggerScript.rightPlateWeight == 44 && leftPlateTriggerScript.leftPlateWeight == 44)
        {
            StartCoroutine(MoveObjectSmoothly(sphere1, sphere1.transform.position, new Vector3(3.25300002f, 1.384f, -5.216f)));
            StartCoroutine(MoveObjectSmoothly(sphere2, sphere2.transform.position, new Vector3(2.753f, 1.384f, -5.216f)));
            playStepsScript.PlayStepIndex(13);
        }

        Debug.Log(rightPlateTriggerScript.rightPlateWeight);
        Debug.Log(leftPlateTriggerScript.leftPlateWeight);
    }

    private IEnumerator MoveObjectSmoothly(GameObject obj, Vector3 startPosition, Vector3 targetPosition)
    {
        isMoving = true;
        float elapsedTime = 0;

        while (elapsedTime < duration)
        {
            obj.transform.position = Vector3.Lerp(startPosition, targetPosition, (elapsedTime / duration));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        obj.transform.position = targetPosition; // Ensure the object reaches the exact target position
        isMoving = false;
    }
}