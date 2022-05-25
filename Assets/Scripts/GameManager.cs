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
    [SerializeField] Spawner orbPrefab;
    [SerializeField] GameObject Arenagrid;
    public GridSquare currentSquare;

    public int startgame = 0;

    public GameObject grid1;
    public GameObject Screen1;
    public GameObject Screen2;
    public GameObject Warning1;
    public GameObject Warning2;

    public Vector3 squarePos;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("currentUnit", 0);
        PlayerPrefs.SetInt("currentPrice", 0);
        PlayerPrefs.SetInt("spawnersOne", 0);
        PlayerPrefs.SetInt("spawnersTwo", 0);
        PlayerPrefs.SetString("currentPlayer", "playerOne");
        menuOne.SetActive(true);
        menuTwo.SetActive(false);
        Arenagrid.GetComponent<Rigidbody2D>().simulated = false;
        StartCoroutine(LevelPopup(Screen1));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 spawnPosition = squarePos;
            if (PlayerPrefs.GetString("currentPlayer") == "playerOne")
            {
                if(PlayerPrefs.GetInt("budgetOne") >= PlayerPrefs.GetInt("currentPrice"))
                {
                    //bool val= CheckPosition(spawnPosition.x, spawnPosition.y,1);
                    bool val = true;
                    switch (PlayerPrefs.GetInt("currentUnit"))
                    {
                        case 0:
                            break;
                        case 1:
                            //GameObject soldier = Instantiate(soldierPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            //Debug.Log("x: "+ spawnPosition.x + "y: "+ spawnPosition.y);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject soldier = Instantiate(soldierPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                soldier.tag = "Team1";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Occupied");
                            }

                                break;
                        case 2:
                            //GameObject archer = Instantiate(archerPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            //Debug.Log("x: " + spawnPosition.x + "y: " + spawnPosition.y);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject archer = Instantiate(archerPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //archer.tag = "Team1";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Occupied");
                            }

                            break;
                        case 3:
                            //GameObject towerOne = Instantiate(towerOnePrefab, new Vector2(spawnPosition.x , spawnPosition.y), Quaternion.identity);
                            Debug.Log("x: " + spawnPosition.x + "y: " + spawnPosition.y);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject towerOne = Instantiate(towerOnePrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //towerOne.tag = "Team1";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Occupied");
                            }
                            break;
                        case 4:
                            //GameObject towerTwo = Instantiate(towerTwoPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            //Debug.Log("x: " + spawnPosition.x + "y: " + spawnPosition.y);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject towerTwo = Instantiate(towerTwoPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //towerTwo.tag = "Team1";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Occupied");
                            }
                            break;
                        case 5:
                            //GameObject hero = Instantiate(heroPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            //Debug.Log("x: " + spawnPosition.x + "y: " + spawnPosition.y);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject hero = Instantiate(heroPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //hero.tag = "Team1";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Occupied");
                            }
                            break;
                        case 6:
                            //GameObject fence = Instantiate(fencePrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            //Debug.Log("x: " + spawnPosition.x + "y: " + spawnPosition.y);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject fence = Instantiate(fencePrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //fence.tag = "Team1";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Occupied");
                            }
                            break;
                        case 7:
                            //GameObject wall = Instantiate(wallPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            //Debug.Log("x: " + spawnPosition.x + "y: " + spawnPosition.y);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject wall = Instantiate(wallPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //wall.tag = "Team1";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Occupied");
                            }
                            break;
                        case 8:
                            if(PlayerPrefs.GetInt("spawnersOne") != 3)
                            {
                                //PlayerPrefs.SetInt("spawnersOne", PlayerPrefs.GetInt("spawnersOne")+1);
                                //Spawner orb = Instantiate(orbPrefab, new Vector2(spawnPosition.x , spawnPosition.y), Quaternion.identity);
                                //Debug.Log("x: " + spawnPosition.x + "y: " + spawnPosition.y);
                                if (currentSquare.isOccupied == false)
                                {
                                    PlayerPrefs.SetInt("spawnersOne", PlayerPrefs.GetInt("spawnersOne") + 1);
                                    Spawner orb = Instantiate(orbPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                    //orb.tag = "Team1";
                                    currentSquare.isOccupied = true;
                                    orb.orbOne.SetActive(true);
                                    PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - PlayerPrefs.GetInt("currentPrice"));
                                }
                                else
                                {
                                    Debug.Log("Occupied");
                                }
                                
                            }
                            break;
                    }
                    

                        
                }
                
            }
            else if(PlayerPrefs.GetString("currentPlayer") == "playerTwo")
            {
                if (PlayerPrefs.GetInt("budgetTwo") >= PlayerPrefs.GetInt("currentPrice"))
                {
                    //bool val = CheckPosition(spawnPosition.x, spawnPosition.y, 2);
                    bool val = true;
                    switch (PlayerPrefs.GetInt("currentUnit"))
                    {
                        case 0:
                            break;
                        case 1:
                            //GameObject soldier = Instantiate(soldierPrefab, new Vector2(spawnPosition.x , spawnPosition.y), Quaternion.identity);                           
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject soldier = Instantiate(soldierPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                soldier.tag = "Team2";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Ouside Area");
                            }
                            break;
                        case 2:
                            //GameObject archer = Instantiate(archerPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject archer = Instantiate(archerPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //archer.tag = "Team2";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Ouside Area");
                            }
                            break;
                        case 3:
                            //GameObject towerOne = Instantiate(towerOnePrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject towerOne = Instantiate(towerOnePrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //towerOne.tag = "Team2";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Ouside Area");
                            }
                            break;
                        case 4:
                            //GameObject towerTwo = Instantiate(towerTwoPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject towerTwo = Instantiate(towerTwoPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //towerTwo.tag = "Team2";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Ouside Area");
                            }
                            break;
                        case 5:
                            //GameObject hero = Instantiate(heroPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject hero = Instantiate(heroPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //hero.tag = "Team2";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Ouside Area");
                            }
                            break;
                        case 6:
                            //GameObject fence = Instantiate(fencePrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject fence = Instantiate(fencePrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //fence.tag = "Team2";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Ouside Area");
                            }
                            break;
                        case 7:
                            //GameObject wall = Instantiate(wallPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                            if (currentSquare.isOccupied == false)
                            {
                                GameObject wall = Instantiate(wallPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                //wall.tag = "Team2";
                                currentSquare.isOccupied = true;
                                PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - PlayerPrefs.GetInt("currentPrice"));
                            }
                            else
                            {
                                Debug.Log("Ouside Area");
                            }
                            break;
                        case 8:
                            if (currentSquare.isOccupied == false)
                            {
                               if (PlayerPrefs.GetInt("spawnersTwo") != 3)
                                {
                                    PlayerPrefs.SetInt("spawnersTwo", PlayerPrefs.GetInt("spawnersTwo") + 1);
                                    Spawner orb = Instantiate(orbPrefab, new Vector2(spawnPosition.x, spawnPosition.y), Quaternion.identity);
                                    //orb.tag = "Team2";
                                    currentSquare.isOccupied = true;
                                    orb.orbTwo.SetActive(true);
                                    PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - PlayerPrefs.GetInt("currentPrice"));
                                }
                            }
                            else
                            {
                                Debug.Log("Ouside Area");
                            }    
                            break;
                    }
                    
                }
                    
            }
            
        }
    }

    IEnumerator LevelPopup(GameObject screenV)
    {

        screenV.SetActive(true);
        yield return new WaitForSeconds(2);
        screenV.SetActive(false);
    }
    public bool CheckPosition(float x, float y, int player)
    {
        if ((player == 1) && ((x > -0.01) || (y > 0.62) || (y < -0.62) || (x < -1.412)))
        {
            //Debug.Log("Outside Area");
            StartCoroutine(LevelPopup(Warning1));
            return false;
        }
        else
        {
            if ((player == 2) && ((x < -0.05) || (y > 0.62) || (y < -0.62) || (x > 1.412)))
            {
                //Debug.Log("Outside Area");
                StartCoroutine(LevelPopup(Warning2));
                return false;
            }
            else
                return true;
        }



    }
    public void StartGame()
    {
        startgame = 1;
       grid1.SetActive(false);
    }


}
