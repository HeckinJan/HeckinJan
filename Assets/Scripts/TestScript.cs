using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.sceneManagement;


public class TestScript : MonoBehaviour
{
    RigidBody rb;
    public GameObject winText;
    float xInput;
    float zInput;

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);

            //rb.AddForce(Vector3.up * 500);
        }

        //rb.velocity = Vector3.forward * 20f;    

        //How to load "Level2" scene by pressing R on keyboard:
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level2"); 
        }

        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * speed, 0, zInput * speed);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(gameObject);
            Destroy(collision.gameObject);

            winText.SetActive(true);
        }
    }
}
