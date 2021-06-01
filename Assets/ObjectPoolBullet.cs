using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolBullet : MonoBehaviour
{
    Rigidbody2D bulletrb;
    // Start is called before the first frame update
    void Start()
    {
        bulletrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
