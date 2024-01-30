using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] tutorialSpawners;
    int tutorialIndex = 0;
    GameObject currentManager;
    GameObject[] usedManagers = {};
    [SerializeField] GameObject visual;
    public bool canChange;
    public bool tutorial;
    public float tutorialLength;
    public float tutorialStartTime;
    public string[] SceneNames = {"Autonomy Variation",
                                  "Competence Variation",
                                  "Relatedness Variation"};

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
        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            SceneManager.LoadScene(0);
        }
        //string nextScene = SceneNames[Random.Range(0, SceneNames.Length)];

        //while (nextScene == SceneManager.GetActiveScene().name)
        //{
        //    nextScene = SceneNames[Random.Range(0, SceneNames.Length)]; ;
        //    SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        //}
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void ToggleManager()
    {
        if(tutorial)
        {
            tutorialStartTime = Time.time;
        }
        visual.SetActive(!visual.activeInHierarchy);
        gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
    }

    public void EndTutorial()
    {
        foreach(var spawner in tutorialSpawners)
        {
            spawner.SetActive(false);
        }
        ToggleManager();
        tutorial = false;
    }
}