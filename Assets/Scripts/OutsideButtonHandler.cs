using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class OutsideButtonHandler : MonoBehaviour
{
    public GameObject outsideButton;
    public GameObject middleButton;

    // Start is called before the first frame update
    void Start()
    {       
        //#TODO FOR JAN - create gameobjects with these names: 
        outsideButton = GameObject.Find("Outside Button"); 
        middleButton = GameObject.Find("Middle Button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButtonPress()
    {

        
    }

    

    
       
}
