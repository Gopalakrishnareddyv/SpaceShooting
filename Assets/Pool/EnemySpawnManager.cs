using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2.0f)
        {
           
            GameObject et = Pool.instance.Get("enemy");
            {
                float value = Random.Range(-2.2f, 2.2f);
                //this.transform.position = new Vector3(value, 6.0f, 0);
                et.transform.position = new Vector3(value, 6.0f, 0);
                et.SetActive(true);
            }
            //GameObject enemyref = Instantiate(enemy);
            //enemyref.transform.position = new Vector3(value,5.3f, 0);
            time = 0;
        }
    }
}
