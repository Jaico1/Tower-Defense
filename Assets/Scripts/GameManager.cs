using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject menuOne;
    public GameObject menuTwo;

    [SerializeField] GameObject soldierPrefab;
    [SerializeField] GameObject archerPrefab;
    [SerializeField] GameObject towerOnePrefab;
    [SerializeField] GameObject towerTwoPrefab;
    [SerializeField] GameObject heroPrefab;
    [SerializeField] GameObject fencePrefab;
    [SerializeField] GameObject wallPrefab;
    [SerializeField] GameObject orbPrefab;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("currentUnit", 0);
        PlayerPrefs.SetInt("currentPrice", 0);
        PlayerPrefs.SetString("currentPlayer", "playerOne");
        menuOne.SetActive(true);
        menuTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (PlayerPrefs.GetString("currentPlayer") == "playerOne")
            {
                if(PlayerPrefs.GetInt("budgetOne") >= PlayerPrefs.GetInt("currentPrice"))
                {
                    switch (PlayerPrefs.GetInt("currentUnit"))
                    {
                        case 0:
                            break;
                        case 1:
                            GameObject soldier = Instantiate(soldierPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 2:
                            GameObject archer = Instantiate(archerPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 3:
                            GameObject towerOne = Instantiate(towerOnePrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 4:
                            GameObject towerTwo = Instantiate(towerTwoPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 5:
                            GameObject hero = Instantiate(heroPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 6:
                            GameObject fence = Instantiate(fencePrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 7:
                            GameObject wall = Instantiate(wallPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 8:
                            GameObject orb = Instantiate(orbPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                    }
                    PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - PlayerPrefs.GetInt("currentPrice"));
                }
                
            }
            else if(PlayerPrefs.GetString("currentPlayer") == "playerTwo")
            {
                if (PlayerPrefs.GetInt("budgetTwo") >= PlayerPrefs.GetInt("currentPrice"))
                {
                    switch (PlayerPrefs.GetInt("currentUnit"))
                    {
                        case 0:
                            break;
                        case 1:
                            GameObject soldier = Instantiate(soldierPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 2:
                            GameObject archer = Instantiate(archerPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 3:
                            GameObject towerOne = Instantiate(towerOnePrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 4:
                            GameObject towerTwo = Instantiate(towerTwoPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 5:
                            GameObject hero = Instantiate(heroPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 6:
                            GameObject fence = Instantiate(fencePrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 7:
                            GameObject wall = Instantiate(wallPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                        case 8:
                            GameObject orb = Instantiate(orbPrefab, new Vector2(spawnPosition.x + (float)1.1, spawnPosition.y), Quaternion.identity);
                            break;
                    }
                    PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - PlayerPrefs.GetInt("currentPrice"));
                }
                    
            }
            
        }
    }
}
