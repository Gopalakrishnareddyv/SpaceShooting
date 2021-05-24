using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    AudioSource bulletaudio;
    public AudioClip bulletsound;
    // Start is called before the first frame update
    void Start()
    {
        bulletaudio = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject bulletref=Instantiate(bullet);
            bulletref.transform.position = transform.position+new Vector3(0,0.5f,0);
            bulletaudio.clip = bulletsound;
            bulletaudio.Play();
        }
        
    }
}
