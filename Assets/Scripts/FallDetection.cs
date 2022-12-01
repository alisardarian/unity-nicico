using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetection : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene("GameOver");
    }
}
