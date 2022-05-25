using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 0.3f;
    private Transform target;
    [SerializeField] private float attackDamage = 10f;
    [SerializeField] private float attackSpeed = 1f;
    [SerializeField] private float attackdistance = 1f;
    public int team;
    public bool started = false;
    private float canAttack;

    public GameObject CEnemy;

    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (gameObject.tag == "Team1")
        {
            team = 1;
        }
        else
        {
            team = 2;
        }
            
    }


    float closestDistance;
    private GameObject findClosestEnemy()
    {
        GameObject[] objs;
        if (gameObject.tag == "Team1") 
        {
            objs = GameObject.FindGameObjectsWithTag("Team2");
        }
        else
        {
            objs = GameObject.FindGameObjectsWithTag("Team1");
        }
            
        //Debug.Log(objs.Length);
        GameObject closestEnemy = null;

        bool first = true;

        foreach (var obj in objs)
        {
            float distance = Vector3.Distance(obj.transform.position, transform.position);
            if (first)
            {
                closestDistance = distance;
                closestEnemy = obj;
                first = false;
            }
            else if (distance < closestDistance)
            {
                closestEnemy = obj;
                closestDistance = distance;
            }

        }
        return closestEnemy;
    }
    void CheckGameStart()
    {
        if(GameManager.Instance.startgame==1)
        {
            started = true;
        }
    }
    void Update()
    {
        CheckGameStart();

        if (started.Equals(true))
            {
            if (CEnemy == null)
                    {
                        CEnemy = findClosestEnemy();
                        target = CEnemy.GetComponent<Transform>();
                    }

                    if (Vector2.Distance(transform.position, target.position) > attackdistance) //se acerca a atacar
                    {
                        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

                    }
                    if (Vector2.Distance(transform.position, target.position) <= attackdistance) //esta en posicion de attack
                    {
                        if (attackSpeed <= canAttack)
                        {
                            CEnemy.GetComponent<Health>().UpdateHealth(-attackDamage);
                            canAttack = 0;
                        }
                        else
                        {
                            canAttack += Time.deltaTime;
                        }

                    }
        }
        



    }
}
