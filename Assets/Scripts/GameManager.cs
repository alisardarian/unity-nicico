using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static int Score = 0;

    [SerializeField] private TMP_Text tmpScore;
    
    private void Awake()
    {
        Instance = this;
    }

    public void OnBrickDestroy()
    {
        Score++;
        tmpScore.text = Score.ToString();
    }
}