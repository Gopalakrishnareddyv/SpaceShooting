using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rbenemy;
    // Start is called before the first frame update
    void Start()
    {
        rbenemy = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        rbenemy.velocity = new Vector2(0, -1);
    }
}
