using UnityEngine;
using System.Collections;
using UnityEngine.UI;  // IMPORTANT!!!!!!!!

public class countertext : MonoBehaviour
{
    
    public Text scoreText;  // public if you want to drag your text object in there manually
    static int counter;

    void Start()
    {
        
        scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts

    }

    void Update()
    {

        if (counter < 3)
        {

            counter = button.count;
            scoreText.text = "Doses left today:" + (3 - counter) + "\r\n Doses left this week:" + (12 - counter);
        }
        }
}