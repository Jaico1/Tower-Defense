using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public static PlayerUnit Instance;

    public int healthPoints;
    public int speed;
    public int damage;

    public CircleCollider2D attackRadius;

    public bool playerOne;
    public bool playerTwo;

    public bool attackUnit;
    public bool staticUnit;

    public bool cooldown = false;

    private PlayerUnit enemy;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerPrefs.GetString("currentPlayer"))
        {
            case "playerOne":
                this.tag = "playerOneUnit";
                this.playerOne = true;
                break;

            case "playerTwo":
                this.tag = "playerTwoUnit";
                this.playerTwo = true;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealthPoints();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag(this.tag) == false)
        {
            enemy = collision.gameObject.GetComponent<PlayerUnit>();
            if (cooldown == false)
            {
                InvokeRepeating("Attack", 0, 1);                                      //QUEDE AQUI
            }
        }
    }

    private void Attack()
    {
        this.enemy.healthPoints = this.enemy.healthPoints - this.damage;
        Debug.Log("Ataque");
        cooldown = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(this.tag) == false)
        {
            StopAllCoroutines();
        }
    }

    private void CheckHealthPoints()
    {
        if(healthPoints <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
