using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    
    public void UpdateScore()
    {
        score++;
        Debug.Log(score);
        scoreText.text = score.ToString();
    }
}
