using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
              
    }

    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //load previous scene
    }

    public void FirstDoorSwap()
    {
        SceneManager.LoadScene("door1puzzle"); //swap to door1puzzle
    }

    public void SecondDoorSwap()
    {
        SceneManager.LoadScene("door2puzzle"); //swap to door2puzzle
    }
}
