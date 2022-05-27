using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public int price;
    public bool readyButton;
    public bool playerOne;
    public bool playerTwo;
    public int unit;
    public GameObject SWarning1;
    public GameObject SWarning2;
    public GameObject BWarning1;
    public GameObject BWarning2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (readyButton)
        {
            if (PlayerPrefs.GetString("currentPlayer") == "playerOne")
            {
                if(PlayerPrefs.GetInt("budgetOne") > 0)
                {
                    StartCoroutine(LevelPopup(BWarning1));
                }
                else
                {
                    if(PlayerPrefs.GetInt("spawnersOne") == 3)
                    {
                        GameManager.Instance.menuTwo.SetActive(true);
                        GameManager.Instance.menuOne.SetActive(false);
                        PlayerPrefs.SetInt("currentUnit", 0);
                        PlayerPrefs.SetInt("currentPrice", 0);
                        PlayerPrefs.SetString("currentPlayer", "playerTwo");

                        

                    }  
                    else
                        StartCoroutine(LevelPopup(SWarning1));
                }
            }else if(PlayerPrefs.GetString("currentPlayer") == "playerTwo")
            {
                if (PlayerPrefs.GetInt("budgetTwo") > 0)
                {
                    StartCoroutine(LevelPopup(BWarning2));
                }
                else
                {
                    if (PlayerPrefs.GetInt("spawnersTwo") == 3)
                    {
                        GameManager.Instance.menuTwo.SetActive(false);
                        GameManager.Instance.StartGame();
                        AstarPath.active.Scan();
                        StartCoroutine(Scan());
                    }
                    else
                        StartCoroutine(LevelPopup(SWarning2));
                }
            }
            
                
        }
        else
        {
            PlayerPrefs.SetInt("currentUnit", unit);
            PlayerPrefs.SetInt("currentPrice", price);
            MenuManager.Instance.pointer.transform.position = new Vector2(this.transform.position.x + (float)0.5, this.transform.position.y);
                /*if (playerOne)
                    PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - price);
                else if (playerTwo)
                    PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - price);*/
        }
        
    }
    IEnumerator LevelPopup(GameObject screenV)
    {
        screenV.SetActive(true);
        yield return new WaitForSeconds(2);
        screenV.SetActive(false);
    }
    IEnumerator Scan()
    {
        yield return new WaitForSeconds(1);
        AstarPath.active.Scan();
        StartCoroutine(Scan());
    }
}
