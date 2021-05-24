using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rbplayer;
    public float playerspeed;
    public Player localplayer;
    AudioSource playerblast;
    public AudioClip playerclip;
    // Start is called before the first frame update
    void Start()
    {
        rbplayer = GetComponent<Rigidbody2D>();
        playerblast = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        rbplayer.velocity = new Vector2(h, 0) * playerspeed;
        rbplayer.position=new Vector2(Mathf.Clamp(rbplayer.position.x,localplayer.xMin,localplayer.xMax),localplayer.y);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
            //Destroy(collision.gameObject);
            Destroy(this.gameObject);
            playerblast.clip = playerclip;
            playerblast.Play();
            SceneManager.LoadScene(2);

        }
    }
}
[System.Serializable]
public class Player
{
    public float xMin, xMax, y;
}