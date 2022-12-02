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
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
