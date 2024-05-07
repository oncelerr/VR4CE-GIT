using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timescript : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private float timer = 0f;

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Calculate minutes and seconds
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        // Update the TextMeshPro text
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
