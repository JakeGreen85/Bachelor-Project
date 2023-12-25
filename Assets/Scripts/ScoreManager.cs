using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highstreakText;
    public TextMeshProUGUI streakText;
    public int score;
    public int streak;
    public int highscore;
    public int highstreak;
    private void Update() {
        scoreText.text = score.ToString();
        streakText.text = streak.ToString();
        if(streak > highstreak){
            highstreak = streak;
            highstreakText.text = highstreak.ToString();
        }
    }

    public void GameOver(){
        if (score > highscore){
            highscore = score;
            highscoreText.text = highscore.ToString();
        }
        score = 0;
        streak = 0;
    }
}
