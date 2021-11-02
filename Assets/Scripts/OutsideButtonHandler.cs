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
        outsideButton = GameObject.find("Outside Button");
        middleButton = GameObject.find("Middle Button")
        //The button shouldn't be there until the player clicks the door. If the player clicks the button, the door unlocks and the button vanishes. 
        //If the player clicks outside the button the button vanishes again, without unlocking the door.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    
       
}
