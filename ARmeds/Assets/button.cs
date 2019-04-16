using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class button : MonoBehaviour
{

    public static int count = 0;
    bool rotateStatus = false;


    public void Rotasi()
    {

        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    void Update()
    {
        if (rotateStatus == true)
        {
            count = count + 1;
            rotateStatus = false;
            
        }
        if(count==3)
        {
            count = count;
        }
    }
}