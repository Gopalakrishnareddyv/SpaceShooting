using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    AudioSource bulletaudio;
    public AudioClip bulletsound;
    public GameObject currentbullet;
    Stack<GameObject> bulletpool = new Stack<GameObject>();
    private static BulletSpawn instance;

    public static BulletSpawn Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<BulletSpawn>();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        bulletaudio = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject bulletref=Instantiate(bullet);
            bulletref.transform.position = transform.position+new Vector3(0,0.5f,0);
            bulletaudio.clip = bulletsound;
            bulletaudio.Play();
        }*/
        if (Input.GetKeyDown(KeyCode.UpArrow))//spawning
        {
            BulletSpawning();
            bulletaudio.clip = bulletsound;
            bulletaudio.Play();
        }
               
    }
    public void CreatePool()//creating object pool method for bullets
    {
        {
            bulletpool.Push(Instantiate(bullet));
            bulletpool.Peek().SetActive(false);
            bulletpool.Peek().name = "Bullet";
        }
        
    }
    public void addBullet(GameObject bullettemp)//adding missed bullet
    {
        bulletpool.Push(bullettemp);
        bulletpool.Peek().SetActive(false);
            
    }
    public void BulletSpawning()//spawning the bullets when stack is empty
    {
        if (bulletpool.Count==0)
        {
            CreatePool();
        }
        GameObject temp = bulletpool.Pop();
        temp.SetActive(true);
        temp.transform.position = transform.position + new Vector3(0, 0.5f, 0);
        currentbullet = temp;
    }
}
