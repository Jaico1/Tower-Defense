using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject menuOne;
    public GameObject menuTwo;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("currentPlayer", "playerOne");
        menuOne.SetActive(true);
        menuTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
