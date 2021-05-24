using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoretext;
    int score = 0;
    public void Increment()
    {
        score++;
        scoretext.text = "Score is "+score;
    }
}
