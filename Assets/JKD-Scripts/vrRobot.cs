using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class vrRobot : MonoBehaviour
{
    [SerializeField] ScoreMngr _ScoreMngr;
    [SerializeField] AudioMngr _AudioMngr;
    [SerializeField] GameMngr _GameMngr;
    [SerializeField] Checkpoint _Checkpoint;
    [SerializeField] GameObject[] _BoardContent;
    [SerializeField] GameObject _subtitlePanel;
    [SerializeField] public GameObject[] _subtitles;
    [SerializeField] public GameObject[] _subtitles2;
    [SerializeField] doorAnimation _doorAnimation;
    [SerializeField] doorAnimation2 _doorAnimation2;
    public float hoverHeight = 1f;
    public Vector3[] position;
    private float hoverSpeed = 1f;
    public int currScript;
    public int prevScript;
    public static bool currentStepExecuted = false;
    public static bool currentStepExecuted2 = false;
    public static bool currentStepExecuted3 = false;
    public static bool currentStepExecuted4 = false;
    public static bool currentStepExecuted5 = false;
    Sequence hoverSequence;


    // In this method, it checks here if the scripts are referenced in the editor.
    private void Awake() 
    {
        if(_Checkpoint == null)
        {
            Debug.LogError("_Checkpoint script is not reference!");
        }
    }
    
    private void Start() 
    {
        // Reset Variables
        currentStepExecuted = false;
        currScript = 0;
        prevScript = 0;
    }
    private void Update() 
    {
        // Steps for level 1 
        Sub1ExperimentSteps();
        // Steps for level 2
        Sub2ExperimentSteps();
        // Steps for level 3
        Sub3ExperimentSteps();
        // Steps for level 4
        Sub4ExperimentSteps();
        // Steps for level 5
        Sub5ExperimentSteps();
        
    }
    
    
    // SUBLEVEL 1


    public void p1() //PPE Check sub1
    {
        Sequence p1sequence = DOTween.Sequence();
        p1sequence.AppendCallback(() => _subtitlePanel.SetActive(false)); // Panel off
        p1sequence.AppendInterval(1.7f);  // Delay
        p1sequence.AppendCallback(() => _doorAnimation.OpenDoor()); // s20
        p1sequence.AppendInterval(1f);  // Delay
        p1sequence.Append(transform.DOMove(position[1], 2f));  // VRBot will enter the PPE room
        p1sequence.AppendCallback(() => _doorAnimation.CloseDoor()); // PPE room door will close
        p1sequence.AppendCallback(() => RotateVRbot(360f, 1f)); // VRBot will face the player
        p1sequence.AppendCallback(() => HoverVRbot(true)); // VRBot will hover
        p1sequence.AppendInterval(1.5f); // Delay of 1.5s
        p1sequence.AppendCallback(() => _subtitlePanel.SetActive(true)); // Subtitle panel will be set active
        p1sequence.AppendCallback(() => PlayVRbotScript(1)); // s1       Subtitle 2 text will be set active
        p1sequence.AppendInterval(_AudioMngr.vrBotVoice[1].length); // Add delay according to the voice over`s duration
        p1sequence.AppendCallback(() => PlayVRbotScript(2)); // s2     
        p1sequence.AppendInterval(_AudioMngr.vrBotVoice[2].length); // Delay
        p1sequence.AppendCallback(() => PlayVRbotScript(3)); // s3      
        p1sequence.AppendInterval(_AudioMngr.vrBotVoice[3].length); // Delay
        p1sequence.AppendCallback(() => PlayVRbotScript(4)); // s4      
        p1sequence.AppendInterval(_AudioMngr.vrBotVoice[4].length+.5f); // Delay + 3s for a bit pause
        p1sequence.AppendCallback(() => PlayVRbotScript(5)); // s5      
        p1sequence.AppendInterval(_AudioMngr.vrBotVoice[5].length); // Delay
        p1sequence.AppendCallback(() => PlayVRbotScript(6)); // s6      
        p1sequence.AppendInterval(_AudioMngr.vrBotVoice[6].length); // Delay
        p1sequence.AppendCallback(() => PlayVRbotScript(7)); // s7      
        p1sequence.Play(); 
    }

    public void p2()
    {
        Sequence p2sequence = DOTween.Sequence();
        p2sequence.AppendCallback(() => PlayVRbotScript(8)); // s8
        p2sequence.AppendInterval(_AudioMngr.vrBotVoice[8].length); // Delay
        p2sequence.AppendCallback(() => _subtitlePanel.SetActive(false)); // Subtitle panel will be set inactive
        p2sequence.AppendCallback(() => RotateVRbot(90f, .2f)); // VRBot will face the exit room
        p2sequence.AppendInterval(.3f); // Delay of .3s
        p2sequence.Append(transform.DOMove(position[2], 3f)); // VRBot will exit the PPE room
        p2sequence.AppendCallback(() => HoverVRbot(false));  //VRBot`s hover is set inactive
        p2sequence.AppendCallback(() => RotateVRbot(450f, .3f)); 
        p2sequence.AppendCallback(() => RotateVRbot(-90f, .3f));
        p2sequence.AppendCallback(() => HoverVRbot(true));
        p2sequence.AppendInterval(1.5f);
        p2sequence.AppendCallback(() => _subtitlePanel.SetActive(true)); // Subtitle panel will be set active
        p2sequence.AppendCallback(() => PlayVRbotScript(9)); // s9
        p2sequence.AppendInterval(_AudioMngr.vrBotVoice[9].length); // Delay
        p2sequence.AppendCallback(() => _Checkpoint.ShowCheckpoint(Checkpoint._CheckpointIndexSub1));
        p2sequence.Play(); 
    }

    public void p3()  
    {
        Sequence p3sequence = DOTween.Sequence();
        p3sequence.AppendCallback(() => _subtitlePanel.SetActive(false)); // Subtitle panel will be set inactive
        p3sequence.AppendCallback(() => HoverVRbot(false)); //Hover OFF 
        p3sequence.AppendCallback(() => RotateVRbot(34.1f, .3f));   //VRBot will face to the 3rd position
        p3sequence.AppendInterval(.5f);  // Delay of .5s
        p3sequence.Append(transform.DOMove(position[3], 1.5f));  //VRBot will move to the 3rd position
        p3sequence.AppendCallback(() => RotateVRbot(120f, .3f));   //VRBot will face the player
        p3sequence.AppendInterval(.5f);  // Delay of .5s
        p3sequence.AppendCallback(() => HoverVRbot(true));  // Hover ON
        p3sequence.AppendCallback(() => _subtitlePanel.SetActive(true)); // Subtitle panel will be set active
        p3sequence.AppendCallback(() => PlayVRbotScript(10)); // s10
        p3sequence.AppendInterval(_AudioMngr.vrBotVoice[10].length); // Delay
        p3sequence.AppendCallback(() => PlayVRbotScript(11)); // s11
        p3sequence.AppendInterval(_AudioMngr.vrBotVoice[11].length); // Delay
        p3sequence.AppendCallback(() => _BoardContent[1].SetActive(true)); // activate board content
        p3sequence.AppendCallback(() => PlayVRbotScript(12)); // s12
        p3sequence.AppendInterval(_AudioMngr.vrBotVoice[12].length); // Delay
        p3sequence.AppendCallback(() => PlayVRbotScript(13)); // s13
        p3sequence.AppendInterval(_AudioMngr.vrBotVoice[13].length); // Delay
        p3sequence.Play(); 
    }

    public void p4() //PPE Check sub2
    {
        Sequence p4sequence = DOTween.Sequence();
        p4sequence.AppendCallback(() => _subtitlePanel.SetActive(false)); // Panel off
        p4sequence.AppendCallback(() => HoverVRbot(false));// Hover OFF   
        p4sequence.AppendInterval(1.7f);  // Delay
        p4sequence.AppendCallback(() => _doorAnimation.OpenDoor()); // Open PPE room door 
        p4sequence.AppendInterval(.3f);  // Delay 
        p4sequence.Append(transform.DOMove(position[1], 2f));  // VRBot will enter the PPE room
        p4sequence.AppendCallback(() => _doorAnimation.CloseDoor()); // PPE room door will close
        p4sequence.AppendCallback(() => RotateVRbot(360f, 1f)); // VRBot will face the player
        p4sequence.AppendCallback(() => HoverVRbot(true)); // Hover ON
        p4sequence.AppendInterval(1.5f); // Delay of 1.5s
        p4sequence.AppendCallback(() => _subtitlePanel.SetActive(true)); // Subtitle panel will be set active
        p4sequence.AppendCallback(() => PlayVRbotScript2(1)); // s1       Subtitle 2 text will be set active
        p4sequence.AppendInterval(_AudioMngr.vrBotVoice2[1].length); // Add delay according to the voice over`s duration
        p4sequence.AppendCallback(() => PlayVRbotScript2(2)); // s2     
        p4sequence.AppendInterval(_AudioMngr.vrBotVoice2[2].length); // Delay
        p4sequence.AppendCallback(() => PlayVRbotScript2(3)); // s3      
        p4sequence.AppendInterval(_AudioMngr.vrBotVoice2[3].length); // Delay
        p4sequence.AppendCallback(() => PlayVRbotScript2(4)); // s4      
        p4sequence.AppendInterval(_AudioMngr.vrBotVoice2[4].length+.5f); // Delay + 3s for a bit pause
        p4sequence.AppendCallback(() => PlayVRbotScript2(5)); // s5      
        p4sequence.AppendInterval(_AudioMngr.vrBotVoice2[5].length); // Delay
        p4sequence.AppendCallback(() => PlayVRbotScript2(6)); // s6      
        p4sequence.AppendInterval(_AudioMngr.vrBotVoice2[6].length); // Delay
        p4sequence.AppendCallback(() => PlayVRbotScript2(7)); // s7      
        p4sequence.Play(); 

    }
    
    
    // SUBLEVEL 2


    public void p5()
    {
        Sequence p5sequence = DOTween.Sequence();
        p5sequence.AppendCallback(() => PlayVRbotScript2(8)); // s8
        p5sequence.AppendInterval(_AudioMngr.vrBotVoice2[8].length); // Delay
        p5sequence.AppendCallback(() => _subtitlePanel.SetActive(false)); // Subtitle panel will be set inactive
        p5sequence.AppendCallback(() => RotateVRbot(90f, .2f)); // VRBot will face the exit room
        p5sequence.AppendInterval(.3f); // Delay of .3s
        p5sequence.Append(transform.DOMove(position[2], 3f)); // VRBot will exit the PPE room
        p5sequence.AppendCallback(() => HoverVRbot(false));  //VRBot`s hover is set inactive
        p5sequence.AppendCallback(() => RotateVRbot(450f, .3f)); 
        p5sequence.AppendCallback(() => RotateVRbot(-90f, .3f));
        p5sequence.AppendCallback(() => HoverVRbot(true)); //Hover ON
        p5sequence.AppendInterval(1.5f); // Delay
        p5sequence.AppendCallback(() => _subtitlePanel.SetActive(true)); // Subtitle panel will be set active
        p5sequence.AppendCallback(() => PlayVRbotScript2(9)); // s9
        p5sequence.AppendInterval(_AudioMngr.vrBotVoice2[9].length); // Delay
        p5sequence.AppendCallback(() => _Checkpoint.ShowCheckpoint(Checkpoint._CheckpointIndexSub2));  // Show next path 
        p5sequence.AppendCallback(() => HoverVRbot(false)); //Hover OFF
        p5sequence.AppendCallback(() => RotateVRbot(0f, .2f)); // VRBot will face the laboratory 2 
        p5sequence.Append(transform.DOMove(position[5], 2f)); // VRBot will go to laboratory 2
        p5sequence.AppendCallback(() => _doorAnimation2.OpenDoor2()); // Laboratory 2 door will open
        p5sequence.Append(transform.DOMove(position[6], 1f)); // VRBot will go to laboratory 2
        p5sequence.Append(transform.DOMove(position[7], 1f)); // VRBot will go above the table
        p5sequence.AppendCallback(() => RotateVRbot(-90f, .2f)); // VRBot will face the player
        p5sequence.AppendCallback(() => HoverVRbot(true)); //Hover ON
        p5sequence.AppendCallback(() => _GameMngr._doorTrigger2.enabled = true); // Lab 2 door will be enabled
        p5sequence.AppendCallback(() => _Checkpoint.ShowCheckpoint(Checkpoint._CheckpointIndexSub2));  // Show next path 
        p5sequence.Play(); 
    }

    public void p6()
    {
        Sequence p6sequence = DOTween.Sequence();
        p6sequence.AppendInterval(1f); // Delay
        p6sequence.AppendCallback(() => PlayVRbotScript2(10)); // s10
        p6sequence.AppendInterval(_AudioMngr.vrBotVoice2[10].length); // Delay
        p6sequence.AppendCallback(() => PlayVRbotScript2(11)); // s11
        p6sequence.AppendInterval(_AudioMngr.vrBotVoice2[11].length); // Delay
        p6sequence.AppendCallback(() => _BoardContent[2].SetActive(true)); // activate board content
        p6sequence.AppendCallback(() => PlayVRbotScript2(12)); // s12s
        p6sequence.AppendInterval(_AudioMngr.vrBotVoice2[12].length); // Delay
    return;

        p6sequence.AppendCallback(() => _subtitlePanel.SetActive(false)); // Subtitle panel will be set inactive
        p6sequence.AppendCallback(() => RotateVRbot(90f, .2f)); // VRBot will face the exit room
        p6sequence.AppendInterval(.3f); // Delay of .3s
        p6sequence.Append(transform.DOMove(position[2], 3f)); // VRBot will exit the PPE room
        p6sequence.AppendCallback(() => HoverVRbot(false));  //VRBot`s hover is set inactive
        p6sequence.AppendCallback(() => RotateVRbot(450f, .3f)); 
        p6sequence.AppendCallback(() => RotateVRbot(-90f, .3f));
        p6sequence.AppendCallback(() => HoverVRbot(true)); //Hover ON
        p6sequence.AppendInterval(1.5f); // Delay
        p6sequence.AppendCallback(() => _subtitlePanel.SetActive(true)); // Subtitle panel will be set active
        p6sequence.AppendCallback(() => PlayVRbotScript2(9)); // s9
        p6sequence.AppendInterval(_AudioMngr.vrBotVoice2[9].length); // Delay
        p6sequence.AppendCallback(() => _Checkpoint.ShowCheckpoint(Checkpoint._CheckpointIndexSub2));  // Show next path 
        p6sequence.AppendCallback(() => HoverVRbot(false)); //Hover OFF
        p6sequence.AppendCallback(() => RotateVRbot(0f, .2f)); // VRBot will face the laboratory 2 
        p6sequence.Append(transform.DOMove(position[5], 2f)); // VRBot will go to laboratory 2
        p6sequence.AppendCallback(() => _doorAnimation2.OpenDoor2()); // Laboratory 2 door will open
        p6sequence.Append(transform.DOMove(position[6], 1f)); // VRBot will go to laboratory 2
        p6sequence.Append(transform.DOMove(position[7], 1f)); // VRBot will go above the table
        p6sequence.AppendCallback(() => RotateVRbot(-90f, .2f)); // VRBot will face the player
        p6sequence.AppendCallback(() => HoverVRbot(true)); //Hover ON
        p6sequence.AppendCallback(() => _GameMngr._doorTrigger2.enabled = true); // Lab 2 door will be enabled
        p6sequence.AppendCallback(() => _Checkpoint.ShowCheckpoint(Checkpoint._CheckpointIndexSub2));  // Show next path 
        p6sequence.Play(); 
    }
    
    private void HoverVRbot(bool Play)
    {
        Vector3 originalPosition = transform.position;
        Vector3 targetPosition = originalPosition + new Vector3(0, hoverHeight, 0);

        if (Play)
        {
            hoverSequence = DOTween.Sequence();
            hoverSequence.Append(transform.DOMove(targetPosition, hoverSpeed).SetEase(Ease.InOutQuad));
            hoverSequence.Append(transform.DOMove(originalPosition, hoverSpeed).SetEase(Ease.InOutQuad));
            hoverSequence.SetLoops(-1);
            hoverSequence.Play();
        }
        else 
        {
            hoverSequence.Kill(); 
        }
    }
    
    private void RotateVRbot(float FaceRotationY, float FRspeed)
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;
        transform.DORotate(new Vector3(currentRotation.x, FaceRotationY, currentRotation.z), FRspeed, RotateMode.FastBeyond360).SetEase(Ease.Linear);
    }
    
    public void PlayVRbotScript(int currentScript)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.AppendCallback(() => _subtitles[prevScript].SetActive(false)); // 
        sequence.AppendCallback(() => _subtitles[currentScript].SetActive(true)); // 
        sequence.AppendCallback(() => _AudioMngr.PlaySubtitleVoiceOver(_AudioMngr.vrBotVoice[currentScript])); //
        sequence.AppendCallback(() => prevScript = currentScript); // 
        sequence.AppendCallback(() => currScript = currentScript); // 
        sequence.Play(); 
    }
    
    public void PlayVRbotScript2(int currentScript)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.AppendCallback(() => _subtitles2[prevScript].SetActive(false)); // 
        sequence.AppendCallback(() => _subtitles2[currentScript].SetActive(true)); // 
        sequence.AppendCallback(() => _AudioMngr.PlaySubtitleVoiceOver(_AudioMngr.vrBotVoice2[currentScript])); //
        sequence.AppendCallback(() => prevScript = currentScript); // 
        sequence.AppendCallback(() => currScript = currentScript); // 
        sequence.Play(); 
    }
    
    public void PlayScritStep(int Scriptt)
    {
        currentStepExecuted = true;
        Sequence step = DOTween.Sequence();
        step.AppendCallback(() => PlayVRbotScript(Scriptt)); //
        step.AppendInterval(_AudioMngr.vrBotVoice[Scriptt].length); // 
        step.Play(); 
        UIMngr.currentProgress += 14f;

    }
    public void Sub1ExperimentSteps()
    {
        if(GameMngr.CurrentLevelIndex == 1 && GameMngr.S1currentsteps == 1f && !currentStepExecuted) //Step1
        {
            PlayScritStep(14); 
        }  

        if(GameMngr.S1currentsteps == 2f && !currentStepExecuted) //Step2
        {
            PlayScritStep(15); 
        } 

        if(GameMngr.S1currentsteps == 3f && !currentStepExecuted) //Step3
        {
            PlayScritStep(16); 
        } 

        if(GameMngr.S1currentsteps == 4f && !currentStepExecuted) //Step4
        {
            PlayScritStep(17); 
        } 

        if(GameMngr.S1currentsteps == 5f && !currentStepExecuted) //Step5
        {
            PlayScritStep(18); 
        } 

        if(GameMngr.S1currentsteps == 6f && !currentStepExecuted) //Step6
        {
            GameMngr.S1currentsteps = 7f;
            currentStepExecuted = true;
            GameMngr.alreadyReachLastStep = true;
            UIMngr.currentProgress += 16f;
            ScoreMngr.TotalScore = UIMngr.currentProgress;
            Sequence step = DOTween.Sequence();
            step.AppendCallback(() => PlayVRbotScript(19)); // s19
            step.AppendInterval(_AudioMngr.vrBotVoice[19].length); // Delay
            step.AppendCallback(() => PlayVRbotScript(20)); // s20
            step.AppendInterval(_AudioMngr.vrBotVoice[20].length); // Delay
            step.AppendCallback(() => _ScoreMngr.CheckScore()); // verdict
            step.Play(); 
        } 
    }
    public void Sub2ExperimentSteps()
    {
        if(GameMngr.CurrentLevelIndex == 2 && GameMngr.S2currentsteps == 1f && !currentStepExecuted2) //Step1
        {
            // 
        }

        // if(GameMngr.S1currentsteps == 2f && !currentStepExecuted) //Step2
        // {
        //     PlayScritStep(15); 
        // } 

        // if(GameMngr.S1currentsteps == 3f && !currentStepExecuted) //Step3
        // {
        //     PlayScritStep(16); 
        // } 

        // if(GameMngr.S1currentsteps == 4f && !currentStepExecuted) //Step4
        // {
        //     PlayScritStep(17); 
        // } 

        // if(GameMngr.S1currentsteps == 5f && !currentStepExecuted) //Step5
        // {
        //     PlayScritStep(18); 
        // } 

        // if(GameMngr.S1currentsteps == 6f && !currentStepExecuted) //Step6
        // {
        //     currentStepExecuted = true;
        //     GameMngr.alreadyReachLastStep = true;
        //     UIMngr.currentProgress += 16f;
        //     ScoreMngr.TotalScore = UIMngr.currentProgress;
        //     Sequence step = DOTween.Sequence();
        //     step.AppendCallback(() => PlayVRbotScript(19)); // s19
        //     step.AppendInterval(_AudioMngr.vrBotVoice[19].length); // Delay
        //     step.AppendCallback(() => PlayVRbotScript(20)); // s20
        //     step.AppendInterval(_AudioMngr.vrBotVoice[20].length); // Delay
        //     step.AppendCallback(() => _ScoreMngr.CheckScore()); // verdict
        //     step.Play(); 
        // } 
    }
    public void Sub3ExperimentSteps()
    {
        // 
    }
    public void Sub4ExperimentSteps()
    {
        // 
    }
    public void Sub5ExperimentSteps()
    {
        // 
    }

}