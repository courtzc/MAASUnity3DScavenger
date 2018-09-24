using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // this is boilerplate code to allow you to use this as a singleton
    #region SINGLETON PATTERN
    public static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    GameObject container = new GameObject("GameManager");
                    _instance = container.AddComponent<GameManager>();
                }
            }

            return _instance;
        }
    }
    #endregion
    /*----------------
     * Valid modes
     * 
     * setup - For placing objects
     * playing - In simulation mode
     * playingserver - Playing in server mode (only server can give back control)
     * select - When adding objects to the level so you can't move
     * 
     * ---------------*/
    // determines if the game is playing or not (and )
    public string gameMode = "setup";
    // this used to determine if you are on rotate or move (or any other toolds)
    public string interactionMode = "move";

    public GameObject canvasGlobalPlay;

    // these are UI buttons for the basic scene
    public Image imageBtnMove;
    public Image imageBtnRotate;
    public Image imageBtnPlay;
    public Image imageBtnReset;
    // public Image imageBtnAdd;

    public Sprite spriteStop;
    public Sprite[] spriteRotate;
    public Sprite spritePlay;

    // this is used to to track the ball and determine if the game is won
    public GameObject gameBall;
    // this lets the game know to progress if in global play mode
    public bool isNextScreen = false;
    public bool isScreenLocked = false;


    // this is used to determine where in the chain the screen is
    private int screenNumber;

    // this is for creating the tick on win
    public GameObject objTick;

    // the puzzle complete canvas
    public GameObject canvasPuzzleComplete;
    // the stop simulation canvas
    public GameObject canvasStop;

    // Use this for initialization
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Simply reloads the level to give a clean level. Doesn't play in play modes
    public void ResetLevel()
    {

    }

    

    //this calls resets the level and progresses the level
    public void NextLevelAndReset()
    {

    }

}

