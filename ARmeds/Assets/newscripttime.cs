using UnityEngine;
using System.Collections;
using UnityEngine.UI;  // IMPORTANT!!!!!!!!

public class newscripttime : MonoBehaviour
{
    int hours = System.DateTime.Now.Hour;
    int minutes = System.DateTime.Now.Minute;
    int seconds = System.DateTime.Now.Second;

    public Text scoreText;  // public if you want to drag your text object in there manually

    void Start()
    {
        scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts

    }

    void Update()
    {
        scoreText.text = "Current time: " + System.DateTime.Now.ToString("HH:mm:ss tt")
            + "               " +
            "\r\n NEXT DOSE IN: " + (15 - 1 - hours) + " hours" + (60 - minutes) + " minutes";  // make it a string to output to the Text object
    }
}