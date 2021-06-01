using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMovement : MonoBehaviour
{
    Rigidbody2D rbbullet;
    public float bulletspeed;
    AudioSource Enemyblast;
    public AudioClip enemyclip;
    ScoreManager scoremanager;
    // Start is called before the first frame update
    void Start()
    {
        rbbullet = GetComponent<Rigidbody2D>();
        Enemyblast = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        scoremanager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        rbbullet.velocity = new Vector2(0, 1)*bulletspeed;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Enemyblast.clip = enemyclip;
            Enemyblast.Play();
            Destroy(this.gameObject);
            scoremanager.Increment();
        }
        else
        {
            
            StartCoroutine(nameof(Bulletadd));
        }
        
            
            
        
    }
    IEnumerator Bulletadd()
    {
        yield return new WaitForSeconds(2);
        print("Missed the ball");
        if (rbbullet.gameObject.name == "Bullet")
        {
            BulletSpawn.Instance.addBullet(rbbullet.gameObject);
            print(rbbullet.gameObject.name);
            print("Adding cannon ball to player");
        }
    }
}
