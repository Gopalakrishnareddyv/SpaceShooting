using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move=Input.GetAxis("Horizontal") * playerspeed*Time.deltaTime;
        transform.Translate(move, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject bt = Pool.instance.Get("bullet");
            {
                bt.transform.position = transform.position;
                bt.SetActive(true);

            }
        }
    }
}
