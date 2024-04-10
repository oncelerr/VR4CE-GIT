using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameMngr : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] Checkpoint _Checkpoint;
    [SerializeField] SceneLoader _SceneLoader;
    [SerializeField] DataMngr _DataMngr;
    [SerializeField] ScoreMngr _ScoreMngr;
    [SerializeField] AudioMngr _AudioMngr;
    [SerializeField] doorAnimation _doorAnimation;
    [SerializeField] vrRobot _vrRobot;

    [Header("Lab Materials")]
    [SerializeField] GameObject[] _LabMaterials;
    
    [Header("Others")]
    public BoxCollider _doorTrigger;
    public BoxCollider _doorTrigger2;
    

    // Database to static variable realtime reference
    public static int CurrentLevelIndex;

    // Level Control
    public static bool level1Done = false;
    public static bool level2Done = false;
    public static bool level3Done = false;
    public static bool level4Done = false;
    public static bool level5Done = false;
 

    // Level Activation
    private bool ppeRoomDone = false;
    private bool lvl1Activated = false;
    private bool lvl2Activated = false;
    private bool lvl3Activated = false;
    private bool lvl4Activated = false;
    private bool lvl5Activated = false;

    // Checkpoints
    public static bool Cpoint1 = false;
    public static bool Cpoint2 = false;
    public static bool Cpoint3 = false;
    public static bool Cpoint4 = false;
    public static bool Cpoint5 = false;
    public static bool Cpoint6 = false;
    public static bool Cpoint7 = false;
 
    // Misc Variables
    public static bool ppe_ready = false;
    public static float S1currentsteps = 0;
    public static float S2currentsteps = 0;
    public static float S3currentsteps = 0;
    public static float S4currentsteps = 0;
    public static float S5currentsteps = 0;
    public static bool alreadyReachLastStep;
    private bool lab1ReachTable;
    private bool lab2Reach;
    private bool lab2ReachTable;


    private void Awake() 
    {
        if(_doorAnimation == null)
        {
            Debug.LogError("_doorAnimation script is not reference!");
        }
        else if(_vrRobot == null)
        {
            Debug.LogError("_vrRobot script is not reference!");
        }
        else if(_doorTrigger == null)
        {
            Debug.LogError("_doorTrigger script is not reference!");
        }
    }
    private void Start() 
    {   
        // Reset Variables
        ppe_ready = false;
        alreadyReachLastStep = false;
        lab1ReachTable = false;
        lab2Reach = false;
        ppeRoomDone = false;
        lab2ReachTable = false;

        // Reference the updated level from the database to static variable
        _DataMngr.LoadMyData();
        CurrentLevelIndex = _DataMngr.player.LevelIndex;

        Debug.Log("The current level is: " +CurrentLevelIndex);
        // Load the level base on the current level from database
        // Setup what level it is
        if(_DataMngr.player.LevelIndex == 1) 
        {
            Debug.Log("LEVEL 1");
            EnableDisableGameObjects(_DataMngr.player.LevelIndex, _LabMaterials);
            _vrRobot.p1();
            Debug.Log("Level 1 is executed");
        }
        else if(_DataMngr.player.LevelIndex == 2) 
        {
            Debug.Log("LEVEL 2");
            EnableDisableGameObjects(_DataMngr.player.LevelIndex, _LabMaterials);
            _vrRobot.p4();
        }
        else if(_DataMngr.player.LevelIndex == 3) 
        {
            Debug.Log("LEVEL 3");
            EnableDisableGameObjects(_DataMngr.player.LevelIndex, _LabMaterials);
        }
        else if(_DataMngr.player.LevelIndex == 4) 
        {
            Debug.Log("LEVEL 4");
            EnableDisableGameObjects(_DataMngr.player.LevelIndex, _LabMaterials);
        }
        else if(_DataMngr.player.LevelIndex == 5) 
        {
            Debug.Log("LEVEL 5");
            EnableDisableGameObjects(_DataMngr.player.LevelIndex, _LabMaterials);
        }
    }

    private void Update() 
    {
        //PPE check all sublevels
        if(ppe_ready && !ppeRoomDone) 
        {
            if(_DataMngr.player.LevelIndex == 1)
            {
                ppeRoomDone = true;
                _doorTrigger.enabled = true;
                _doorAnimation.OpenDoor();
                _vrRobot.p2();
            }
            else if(_DataMngr.player.LevelIndex == 2)
            {
                ppeRoomDone = true;
                _doorTrigger.enabled = true;
                _doorAnimation.OpenDoor();
                _vrRobot.p5();
            }
        }

        // Check if the player reach the table sub1
        if(CurrentLevelIndex == 1 && Checkpoint._CheckpointIndexSub1 == 2 && !lab1ReachTable)
        {
            lab1ReachTable = true;
            _vrRobot.p3();
        }

        // Check if the player reach the lab 2 sub2
        if(CurrentLevelIndex == 2 && Checkpoint._CheckpointIndexSub2 == 3 && !lab2Reach)
        {
            lab2Reach = true;
            _Checkpoint.ShowCheckpoint(Checkpoint._CheckpointIndexSub2);
        }

        // Check if the player reach the lab 2 sub2 and already near the table
        if(CurrentLevelIndex == 2 && Checkpoint._CheckpointIndexSub2 == 4 && !lab2ReachTable)
        {
            lab2ReachTable = true;
            _vrRobot.p6();
        }

        // Equate static to parameter variables

    }

    public void ProceedToNextLevel()
    {
        _ScoreMngr.ScoreMenuObj.SetActive(false);
        _DataMngr.player.LevelIndex = 2;
        _DataMngr.SaveMyData();
        // _SceneLoader.RestartScene();
        _SceneLoader.LoadScene(3);
    }
    public void ResetLvl(int level)
    {
        switch (level)
        {
            case 1:
                _DataMngr.player.LevelIndex = 1;
                _DataMngr.SaveMyData();
                _SceneLoader.RestartScene();
                break;
            case 2:
                _DataMngr.player.LevelIndex = 2;
                _DataMngr.SaveMyData();
                _SceneLoader.RestartScene();
                break;
            case 3:
                _DataMngr.player.LevelIndex = 3;
                _DataMngr.SaveMyData();
                _SceneLoader.RestartScene();
                break;
            case 4:
                _DataMngr.player.LevelIndex = 4;
                _DataMngr.SaveMyData();
                _SceneLoader.RestartScene();
                break;
            case 5:
                _DataMngr.player.LevelIndex = 5;
                _DataMngr.SaveMyData();
                _SceneLoader.RestartScene();
                break;
            default:
                break;
        }
    }

    public void EnableDisableGameObjects(int ToEnableObj, GameObject[] Array)
    {
        Array[ToEnableObj].SetActive(true);
        // disable other lab materials
        for(int i = 0; i < Array.Length; i++) {
            if (i != ToEnableObj) // Skip the object that will be enable
            {
                Array[i].SetActive(false);
            }
        }
    }


}
