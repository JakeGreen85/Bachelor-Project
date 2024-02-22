using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// TODO:
// - Make sure when all missions are complete, then the text is removed

public class MilestoneManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] CompetenceFeedback voiceManager;
    Mission[] streakMissions = { new Mission("10 Streak", "Reach a streak of 10 punches", 10, 0),
                                 new Mission("25 Streak", "Reach a streak of 25 punches", 25, 0),
                                 new Mission("50 Streak", "Reach a streak of 50 punches", 50, 0),
                                 new Mission("100 Streak", "Reach a streak of 100 punches", 100, 0),
                                 new Mission("200 Streak", "Reach a streak of 200 punches", 200, 0),
    };
    Mission[] scoreMissions = {  
                                 new Mission("100 Score", "Reach a score of 100", 0, 100),
                                 new Mission("1000 Score", "Reach a score of ´1000", 0, 1000),
                                 new Mission("5000 Score", "Reach a score of 5000", 0, 5000),
                                 new Mission("10000 Score", "Reach a score of 10000", 0, 10000),
                                 new Mission("25000 Score", "Reach a score of 25000", 0, 25000),
                                 new Mission("50000 Score", "Reach a score of 50000", 0, 50000),
                                 new Mission("100000 Score", "Reach a score of 100000", 0, 100000),
                                 new Mission("250000 Score", "Reach a score of 250000", 0, 250000)
    };
    int scoreMissionIndex = 0;
    int streakMissionIndex = 0;
    [SerializeField] TextMeshProUGUI streakTitle;
    [SerializeField] TextMeshProUGUI streakDescription;
    [SerializeField] TextMeshProUGUI streakProgress;
    [SerializeField] TextMeshProUGUI scoreTitle;
    [SerializeField] TextMeshProUGUI scoreDescription;
    [SerializeField] TextMeshProUGUI scoreProgress;
    [SerializeField] TextMeshProUGUI missionComplete;
    float missionCompleteTime;
    float displayTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        streakTitle.text = streakMissions[streakMissionIndex].Name;
        streakDescription.text = streakMissions[streakMissionIndex].Description;
        scoreTitle.text = scoreMissions[scoreMissionIndex].Name;
        scoreDescription.text = scoreMissions[scoreMissionIndex].Description;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time < missionCompleteTime + displayTime && !missionComplete.gameObject.activeInHierarchy) 
        {
            missionComplete.gameObject.SetActive(true);
        }
        if(Time.time > missionCompleteTime + displayTime && missionComplete.gameObject.activeInHierarchy)
        {
            missionComplete.gameObject.SetActive(false);
        }
        scoreProgress.text = scoreManager.score.ToString() + " / " + scoreMissions[scoreMissionIndex].Score.ToString();
        streakProgress.text = scoreManager.streak.ToString() + " / " + streakMissions[streakMissionIndex].Streak.ToString();
        foreach (var mission in scoreMissions)
        {
            if (mission != null && !mission.Completed)
            {
                if (mission.Score <= scoreManager.score)
                {
                    mission.completed();
                    missionCompleteTime = Time.time;
                    ChangeScoreMissionVisual();
                    voiceManager.playScore(scoreManager.score);
                }
            }
        }
        foreach (var mission in streakMissions)
        {
            if (mission != null && !mission.Completed)
            {
                if (mission.Streak <= scoreManager.streak)
                {
                    mission.completed();
                    missionCompleteTime = Time.time;
                    ChangeStreakMissionVisual();
                }
            }
        }
    }

    void ChangeStreakMissionVisual()
    {
        streakMissionIndex++;
        streakTitle.text = streakMissions[streakMissionIndex].Name;
        streakDescription.text = streakMissions[streakMissionIndex].Description;
        streakProgress.text = scoreManager.streak.ToString() + " / " + streakMissions[streakMissionIndex].Streak.ToString();

    }

    void ChangeScoreMissionVisual()
    {
        scoreMissionIndex++;
        scoreTitle.text = scoreMissions[scoreMissionIndex].Name;
        scoreDescription.text = scoreMissions[scoreMissionIndex].Description;
        scoreProgress.text = scoreManager.score.ToString() + " / " + scoreMissions[scoreMissionIndex].Score.ToString();

    }

}