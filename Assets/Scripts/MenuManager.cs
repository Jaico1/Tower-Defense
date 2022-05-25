using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public bool menuOne;
    public bool menuTwo;


    public Text budget;
    public Text spawnerCount;

    /*public Button soldierButton;
    public Button archerButton;
    public Button towerOneButton;
    public Button towerTwoButton;
    public Button heroButton;
    public Button fenceButton;
    public Button wallButton;
    public Button readyButton;*/

    public GameObject pointer;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (menuOne)
        {
            PlayerPrefs.SetInt("budgetOne", 1500);
        }
        else if (menuTwo)
        {
            PlayerPrefs.SetInt("budgetTwo", 1500);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (menuOne)
        {
            budget.text = "BUDGET: $" + PlayerPrefs.GetInt("budgetOne");
            spawnerCount.text = "SPAWNERS: " + PlayerPrefs.GetInt("spawnersOne") + "/3";
        }
        else if (menuTwo)
        {
            budget.text = "BUDGET: $" + PlayerPrefs.GetInt("budgetTwo");
            spawnerCount.text = "SPAWNERS: " + PlayerPrefs.GetInt("spawnersTwo") + "/3";
        }
        
    }

   
}
