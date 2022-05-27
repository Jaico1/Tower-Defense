using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance;

    public GameObject orbOne;
    public GameObject orbTwo;
    [SerializeField] GameObject soldierPrefab;
    public float posx;
    public float posy;
    public Vector3 CurrentSquare;
    bool start;
    int once = 0;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SpawnerUnits(Vector3 squarePos)
    {
        CurrentSquare = squarePos;
        posx = squarePos.x;
        posy = squarePos.y;
        if (start.Equals(true))
            StartCoroutine(UnitSpawn(posx,posy));
        
    }
    IEnumerator UnitSpawn( float x, float y)
    {
        yield return new WaitForSeconds(30);
        GameObject soldier = Instantiate(soldierPrefab, new Vector2(x, y), Quaternion.identity);

        if (gameObject.tag == "Team1")
        {
            soldier.tag = "Team1";
        }
        else if (gameObject.tag=="Team2")
        {
            soldier.tag = "Team2";
        }
        StartCoroutine(UnitSpawn(x,y));

    }

    // Update is called once per frame
    void Update()
    {
        if ((GameManager.Instance.startgame == 1)&&(once==0))
        {
            start = true;
            SpawnerUnits(CurrentSquare);
            once = 1;
        }
            
        
        
    }
}
