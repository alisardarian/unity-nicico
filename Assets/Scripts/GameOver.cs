using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private TMP_Text finalScore;

    private void Start()
    {
        finalScore.text = GameManager.TotalScore.ToString();
        GameManager.TotalScore = 0;
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
