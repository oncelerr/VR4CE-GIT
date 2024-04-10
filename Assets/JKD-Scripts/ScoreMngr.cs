using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class ScoreMngr : MonoBehaviour
{
    public AudioMngr _AudioMngr;
    public GameObject ScoreMenuObj;
    public GameObject[] Stars;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI Performance;
    public TextMeshProUGUI NextBtnText;
    public GameObject NextBtnObj;
    public Button NextBtn;

    public Color RedBtn = Color.red;
    public Color GreenBtn = Color.green;

    public static float TotalScore;

    private void Start() 
    {
        ScoreMenuObj.SetActive(false);
    }
    public void CheckScore()
    {
        ScoreMenuObj.SetActive(true);
        if(TotalScore < 65) 
        {
            Score.text = "45%";
            Performance.text = "FAILED!";
            NextBtnText.text = "TRY AGAIN!";
            NextBtnObj.SetActive(true);
            NextBtn.image.color = RedBtn;
            Stars[0].SetActive(true);
            Stars[1].SetActive(false);
            Stars[2].SetActive(false);
            Stars[3].SetActive(false);
            _AudioMngr.PlayPerformance(_AudioMngr.verdict[3]);
        }
        else if(TotalScore >= 65 && TotalScore < 75) 
        {
            Score.text = "65%";
            Performance.text = "GOOD!";
            NextBtnText.text = "PROCEED!";
            NextBtnObj.SetActive(true);
            NextBtn.image.color = GreenBtn;
            Stars[0].SetActive(false);
            Stars[1].SetActive(true);
            Stars[2].SetActive(false);
            Stars[3].SetActive(false);
            _AudioMngr.PlayPerformance(_AudioMngr.verdict[2]);
        }
        else if(TotalScore >+ 75 && TotalScore < 90) 
        {
            Score.text = "75%";
            Performance.text = "GREAT!";
            NextBtnText.text = "PROCEED!";
            NextBtnObj.SetActive(true);
            NextBtn.image.color = GreenBtn;
            Stars[0].SetActive(false);
            Stars[1].SetActive(false);
            Stars[2].SetActive(true);
            Stars[3].SetActive(false);
            _AudioMngr.PlayPerformance(_AudioMngr.verdict[1]);
        }
        else if(TotalScore >= 90) 
        {
            Score.text = "90%";
            Performance.text = "EXCELLENT!";
            NextBtnText.text = "PROCEED!";
            NextBtnObj.SetActive(true);
            NextBtn.image.color = GreenBtn;
            Stars[0].SetActive(false);
            Stars[1].SetActive(false);
            Stars[2].SetActive(false);
            Stars[3].SetActive(true);
            _AudioMngr.PlayPerformance(_AudioMngr.verdict[0]);
        }
    }
}
