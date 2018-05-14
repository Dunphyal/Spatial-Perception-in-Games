using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour {

    public int numLives = 3;
    public int numBricks = 64;
    public Text lives;
    public Text Scoring;
    private float SpawnTime;
    private float time;
    private int BallCount = 0;
    private int RandPickUp;
    private int score = 0;
 
    public GameObject Arena;
    private GameObject PlayerBoard;
    public GameObject Ball;
    public GameObject ExtraBall;
    public GameObject Player;
    public GameObject PickUp;
    public GameObject PickUp2;
    public Button RetryButton;
    public Button MainMenuButton;
    

    public static GameControllerScript instance = null;

	// Use this for initialization
	void Start () {
        
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);

        }
            Setup();
	}
	
    void Setup()
    {
        SetRandomSpawnTime();
        time = 0;
        GameObject GameArea = Instantiate(Arena, transform.position, Quaternion.identity);
        PlayerBoard = Instantiate(Player, transform.position, Quaternion.identity);
        GameObject ball = Instantiate(Ball, new Vector3(13.8f, 8f, 0f), Quaternion.identity);
        BallCount++;
        lives.text = "Lives: " + numLives;
    }

    public void PlayerLifes()
    {
        if (BallCount < 1)
        {
            numLives--;
            lives.text = "Lives:" + numLives;
            Destroy(PlayerBoard);
            GameOverCheck();
            Invoke("SetupNewBallandPlayer", 1);
        }
    }

    public void ActiveBallCount()
    {
        BallCount--;
    }

    public void BrickNumber()
    {
        numBricks--;
        GameOverCheck();
    }

    void SetupNewBallandPlayer()
    {
        PlayerBoard = Instantiate(Player, transform.position, Quaternion.identity);
        GameObject ball = Instantiate(Ball, new Vector3(13.8f, 8f, 0f), Quaternion.identity);
        BallCount++;
    }

    void GameOverCheck()
    {
        if (numLives < 1 || numBricks < 1)
        {
            score = numLives * 10 + (64 - numBricks);
            Scoring.text = "You Destroyed " + (64 - numBricks) + " Bricks!" + "\n Score = " + score;
            RetryButton.gameObject.SetActive(true);
            MainMenuButton.gameObject.SetActive(true);
        }
    }

    void SetRandomSpawnTime()
    {
        SpawnTime = Random.Range(10f, 30f);
    }

    void SpawnPickUps()
    {
        time = 0;
        RandPickUp = Random.Range(0, 10);
        if (RandPickUp % 2 == 1)
        {
            GameObject Multiplier = Instantiate(PickUp, new Vector3(Random.Range(4, 6), Random.Range(2, 13), Random.Range(8, -8)), Quaternion.identity);
        }
        else
        {
            GameObject Multiplier2 = Instantiate(PickUp2, new Vector3(Random.Range(4, 6), Random.Range(2, 13), Random.Range(8, -8)), Quaternion.identity);
        }
    }

    public void SpawnExtraBall()
    {
        GameObject MultiBall = Instantiate(Ball, new Vector3(13.8f, 8f, 0f), Quaternion.identity);
        BallCount++;

    }

    public void ScalePlayer()
    {
        PlayerBoard.transform.localScale = new Vector3 (0.5f,4f,6f);
    }

    private void FixedUpdate()
    {

        time += Time.deltaTime;
        if (time >= SpawnTime)
        {
            SpawnPickUps();
            SetRandomSpawnTime();
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("MainMenu");

        }

    }
}
