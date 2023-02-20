using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerCode : MonoBehaviour
{
    public TextMeshProUGUI timer;
    private int time = 505;

    // Update is called once per frame
    void FixedUpdate()
    {
        int wholeSecond = (int)Mathf.Floor(Time.realtimeSinceStartup);
        if (time - wholeSecond >= 0)
        {
            timer.text = $"Time \n   {(time - wholeSecond).ToString()}";
        }
    }
}
