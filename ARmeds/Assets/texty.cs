using UnityEngine;
using System.Collections;
using UnityEngine.UI;  // IMPORTANT!!!!!!!!

public class texty : MonoBehaviour
{

    public Text scoreText;  // public if you want to drag your text object in there manually
    int scoreCounter= System.DateTime.Now.Hour;

    void Start()
    {
        scoreText = GetComponent<Text>();  
    }

    void Update()
    {
        scoreText.text = scoreCounter.ToString();  // make it a string to output to the Text object
    }
}