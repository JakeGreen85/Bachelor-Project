using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject CompetenceManager;
    [SerializeField] GameObject RelatednessManager;
    [SerializeField] GameObject AutonomyManager;
    [SerializeField] GameObject[] tutorialSpawners;
    int tutorialIndex = 0;
    GameObject currentManager;
    GameObject[] usedManagers = {};
    public bool canChange;
    public bool tutorial;
    public float tutorialLength;
    public float tutorialStartTime;

    private void Start()
    {
        if(CompetenceManager != null)
        {
            CompetenceManager.SetActive(false);
        }
        if(RelatednessManager != null) 
        { 
            RelatednessManager.SetActive(false);
        }
        if(AutonomyManager != null)
        {
            AutonomyManager.SetActive(false);
        }
    }

    private void Update()
    {
        if (tutorial)
        {
            if (!tutorialSpawners[tutorialIndex].activeInHierarchy)
            {
                tutorialSpawners[tutorialIndex].SetActive(true);
            }
            if (Time.time > tutorialLength + tutorialStartTime)
            {
                tutorialSpawners[tutorialIndex].SetActive(false);
                tutorialIndex++;
                tutorialStartTime = Time.time;
                if (tutorialIndex >= tutorialSpawners.Length)
                {
                    EndTutorial();
                }
            }
        }
    }

    public void ChangeVariation()
    {
        if (tutorial)
        {
            return;
        }
        if (currentManager != null) 
        {
            currentManager.SetActive(false);
            usedManagers.Append(currentManager);
        }
        int num = Random.Range(0, 3);
        switch (num)
        {
            case 0:
                currentManager = CompetenceManager;
                break;
            case 1:
                currentManager = RelatednessManager;
                break;
            case 2:
                currentManager = AutonomyManager;
                break;
            default: 
                break;
        }
        currentManager.SetActive(true);
        ToggleManager();
    }

    public void ToggleManager()
    {
        if(tutorial)
        {
            tutorialStartTime = Time.time;
        }
    }

    public void EndTutorial()
    {
        foreach(var spawner in tutorialSpawners)
        {
            spawner.SetActive(false);
        }
        ToggleManager();
        tutorial = false;
        SceneManager.LoadScene("Main Scene");
    }
}