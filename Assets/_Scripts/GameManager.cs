using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject CompetenceManager;
    [SerializeField] GameObject RelatednessManager;
    [SerializeField] GameObject AutonomyManager;
    GameObject currentManager;
    GameObject[] usedManagers = {};

    private void Start()
    {
        CompetenceManager.SetActive(false);
        RelatednessManager.SetActive(false);
        AutonomyManager.SetActive(false);
    }
    public void ChangeVariation()
    {
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
        this.gameObject.SetActive(!this.gameObject.activeInHierarchy);
    }
}