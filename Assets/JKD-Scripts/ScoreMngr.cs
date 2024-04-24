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
        // Check first if the current level is not 5
        if(GameMngr.CurrentLevelIndex == 1 || GameMngr.CurrentLevelIndex == 2 || GameMngr.CurrentLevelIndex == 3 || GameMngr.CurrentLevelIndex == 4)
        {
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
                ScoreVerdict(GameMngr.CurrentLevelIndex, 3);
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
                ScoreVerdict(GameMngr.CurrentLevelIndex, 2);
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
                ScoreVerdict(GameMngr.CurrentLevelIndex, 1);
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
                ScoreVerdict(GameMngr.CurrentLevelIndex, 0);
            }
        }
        // If current level is 5 change button will be different
        else if(GameMngr.CurrentLevelIndex == 5)
        {
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
                ScoreVerdict(5, 3);
            }
            else if(TotalScore >= 65 && TotalScore < 75) 
            {
                Score.text = "65%";
                Performance.text = "GOOD!";
                NextBtnText.text = "MAIN MENU";
                NextBtnObj.SetActive(true);
                NextBtn.image.color = GreenBtn;
                Stars[0].SetActive(false);
                Stars[1].SetActive(true);
                Stars[2].SetActive(false);
                Stars[3].SetActive(false);
                ScoreVerdict(5, 2);
            }
            else if(TotalScore >+ 75 && TotalScore < 90) 
            {
                Score.text = "75%";
                Performance.text = "GREAT!";
                NextBtnText.text = "MAIN MENU!";
                NextBtnObj.SetActive(true);
                NextBtn.image.color = GreenBtn;
                Stars[0].SetActive(false);
                Stars[1].SetActive(false);
                Stars[2].SetActive(true);
                Stars[3].SetActive(false);
                ScoreVerdict(5, 1);
            }
            else if(TotalScore >= 90) 
            {
                Score.text = "90%";
                Performance.text = "EXCELLENT!";
                NextBtnText.text = "MAIN MENU!";
                NextBtnObj.SetActive(true);
                NextBtn.image.color = GreenBtn;
                Stars[0].SetActive(false);
                Stars[1].SetActive(false);
                Stars[2].SetActive(false);
                Stars[3].SetActive(true);
                ScoreVerdict(5, 0);
            }
        }
    }

    private void ScoreVerdict(int GameLevel, int verdict)
    {
        switch (GameLevel)
        {
            case 1:
                _AudioMngr.PlayPerformance(_AudioMngr.verdict[verdict]);
                break;
            case 2:
                _AudioMngr.PlayPerformance(_AudioMngr.verdict2[verdict]);
                break;
            case 3:
                _AudioMngr.PlayPerformance(_AudioMngr.verdict3[verdict]);
                break;
            case 4:
                _AudioMngr.PlayPerformance(_AudioMngr.verdict4[verdict]);
                break;
            case 5:
                _AudioMngr.PlayPerformance(_AudioMngr.verdict5[verdict]);
                break;
            default:
                Debug.Log("Undefined sublevel");
                break;
        }
    }
}
