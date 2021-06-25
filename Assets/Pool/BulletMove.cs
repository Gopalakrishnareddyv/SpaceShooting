using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity*Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        //Destroy(this.gameObject);
        this.gameObject.SetActive(false);
        if (gameObject.tag == "bullet")
        {
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(this.gameObject);
            //this.gameObject.SetActive(false);
            //Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);
        }
    }
}
