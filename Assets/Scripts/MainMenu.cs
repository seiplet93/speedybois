using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    Timer timer;
    public string firstLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
        // you cannot load functions from other scenes very easily
        // timer = GameObject.FindGameObjectWithTag("TimerTag").GetComponent<Timer>();
       // timer.StartTimer();
       //Debug.Log(timer);
        
        // Canvas<Timer>();
        // Canvas.GetComponent<Timer>().StartTimer();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
