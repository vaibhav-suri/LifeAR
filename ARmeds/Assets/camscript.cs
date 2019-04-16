using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int hours = System.DateTime.Now.Hour;
        int minutes = System.DateTime.Now.Minute;
        int remhours = 5 - hours;
        int remminutes = 60 - minutes;
        print(" Remaining time for next dose" + " HOURS" + remhours + ' ' + "Minutes" + remminutes);

    }

    // Update is called once per frame

}
