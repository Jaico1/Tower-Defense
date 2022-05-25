using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSquare : MonoBehaviour
{
    
    //public GameObject Inner;
    public BoxCollider2D co;
    
    public bool isOccupied;


    void Start()
    {
        //co = Inner.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void OnMouseDown()
    {
        
        GameManager.Instance.squarePos = this.GetComponent<Transform>().position;
        GameManager.Instance.currentSquare = this;
        //Debug.Log(this);
    }
}
