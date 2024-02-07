using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GradingScript : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Game Manager").GetComponent<ScoreManager>();
        if(scoreManager.score >= 70000)
        {
            GetComponent<TextMeshPro>().text = "Grade: A+";
        }
        else if(scoreManager.score >= 60000)
        {
            GetComponent<TextMeshPro>().text = "Grade: A";
        }
        else if (scoreManager.score >= 50000)
        {
            GetComponent<TextMeshPro>().text = "Grade: A-";
        }
        else if (scoreManager.score >= 40000)
        {
            GetComponent<TextMeshPro>().text = "Grade: B+";
        }
        else if (scoreManager.score >= 30000)
        {
            GetComponent<TextMeshPro>().text = "Grade: B";
        }
        else if (scoreManager.score >= 20000)
        {
            GetComponent<TextMeshPro>().text = "Grade: B-";
        }
        else
        {
            GetComponent<TextMeshPro>().text = "Grade: C+";
        }
    }

}
