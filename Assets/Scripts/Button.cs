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

                }
                else
                {
                    GameManager.Instance.menuTwo.SetActive(true);
                    GameManager.Instance.menuOne.SetActive(false);
                    PlayerPrefs.SetString("currentPlayer", "playerTwo");
                }
            }else if(PlayerPrefs.GetString("currentPlayer") == "playerTwo")
            {
                if (PlayerPrefs.GetInt("budgetTwo") > 0)
                {

                }
                else
                {
                    GameManager.Instance.menuTwo.SetActive(false);
                }
            }
            
                
        }
        else
        {
            PlayerPrefs.SetInt("currentUnit", unit);
            MenuManager.Instance.pointer.transform.position = new Vector2(this.transform.position.x + (float)0.5, this.transform.position.y);
                if (playerOne)
                    PlayerPrefs.SetInt("budgetOne", PlayerPrefs.GetInt("budgetOne") - price);
                else if (playerTwo)
                    PlayerPrefs.SetInt("budgetTwo", PlayerPrefs.GetInt("budgetTwo") - price);
        }
        
    }
}
