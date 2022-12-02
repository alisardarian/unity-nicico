using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static int Score = 0;
    public static int TotalScore = 0;

    [SerializeField] private TMP_Text tmpScore;
    [SerializeField] private TMP_Text tmpCounter;

    public List<Brick> _bricks;

    [SerializeField] private AudioSource breakSfx;

    private Ball _ball;
    private void Awake()
    {
        Instance = this;

        _bricks = FindObjectsOfType<Brick>().ToList();

        _ball = FindObjectOfType<Ball>();
    }

    private void Start()
    {
        Score = 0;
        StartCoroutine(CountDown(false));
    }

    private IEnumerator CountDown(bool fromPause)
    {
        tmpCounter.gameObject.SetActive(true);
        tmpCounter.text = "3";
        yield return new WaitForSecondsRealtime(1);
        tmpCounter.text = "2";
        yield return new WaitForSecondsRealtime(1);
        tmpCounter.text = "1";
        yield return new WaitForSecondsRealtime(1);
        if (!fromPause)
            _ball.AddForceBall();
        else
            Time.timeScale = 1;
        tmpCounter.gameObject.SetActive(false);
    }

    public void OnBrickDestroy(Brick brick)
    {
        breakSfx.pitch = Random.Range(0.5F, 2F);
        breakSfx.Play();
        _bricks.Remove(brick);
        Score++;
        TotalScore++;
        tmpScore.text = Score.ToString();
        
        //check for win
        if (_bricks.Count == 0)
        {
            Debug.Log("Win");
            //load the next level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }

    public void OnPauseButtonClick()
    {
        Time.timeScale = 0;
    }
    
    public void OnPlayButtonClick()
    {
        StartCoroutine(CountDown(true));
    }
    
    
}