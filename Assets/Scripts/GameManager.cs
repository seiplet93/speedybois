
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    [SerializeField]
    private AudioClip _winClip;
   
    private AudioSource _audioSource;
    //public Text time = FindObjectOfType<Timer>().currentTimeText;

    public void Start()
    {
       
    }
    public void CompleteLevel()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = _winClip;
        _audioSource.Play();
        FindObjectOfType<Timer>().StopTimer();
        completeLevelUI.SetActive(true);
        Debug.Log("level won");
       // Debug.Log("yoo????", GameObject.FindGameObjectWithTag("timertexttag"));
        // Text levelComplete = GameObject.FindGameObjectWithTag("LCTAG");
            // GameObject.FindGameObjectWithTag("LCTAG").GetComponent<Text>().text = "yo";
            //GameObject.FindGameObjectWithTag("timertexttag").GetComponent<Text>().text;


    }
    public void EndGame ()
    {
        
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            Restart();
        }
        

    }
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
