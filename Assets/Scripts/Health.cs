using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float health = 0f;
    [SerializeField] private float maxhealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxhealth)
        {
            health = maxhealth;
        }
        else if (health <= 0f)
        {
            health = 0f;
            Destroy(gameObject);
        }
    }
}
