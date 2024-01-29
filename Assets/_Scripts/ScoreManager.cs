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
    public TextMeshProUGUI comboText;
    public int score;
    public int streak;
    public int highscore;
    public int highstreak;
    public int combo;
    private void Update() {
        scoreText.text = score.ToString();
        streakText.text = streak.ToString();
        if(streak > highstreak){
            highstreak = streak;
            highstreakText.text = highstreak.ToString();
        }
        combo = Mathf.Clamp(Mathf.FloorToInt(Mathf.Pow(2f, Mathf.Floor(streak * 0.25f))), 1, 8);
        comboText.text = "x" + combo.ToString();
    }

    public void GameOver(){
        if (score > highscore){
            highscore = score;
            highscoreText.text = highscore.ToString();
        }
        score = 0;
        streak = 0;
        combo = 0;
    }
}