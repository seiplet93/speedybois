using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    bool timerActive = false;
    public float currentTime;
    public int startMinutes;
    public Text currentTimeText;
    public Text currentTimeText2;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60;
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
       currentTimeText.text = "Current Time " + currentTime.ToString();
       currentTimeText2.text = currentTime.ToString() + "s";
    }

    public void StartTimer()
    {
        timerActive = true;
        Debug.Log("timer start?");
    }

    public void StopTimer()
    {
        timerActive = false;
    }
}
