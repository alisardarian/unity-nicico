using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static int Score = 0;

    [SerializeField] private TMP_Text tmpScore;

    public List<Brick> _bricks;

    
    private void Awake()
    {
        Instance = this;

        _bricks = FindObjectsOfType<Brick>().ToList();
    }

    private void Start()
    {
        Score = 0;
    }

    public void OnBrickDestroy(Brick brick)
    {
        _bricks.Remove(brick);
        Score++;
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
        Time.timeScale = 1;
    }
    
    
}