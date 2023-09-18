using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Security.Cryptography;

public class Player : MonoBehaviour
{

    public float speed = 5.0f;
    public int keys = 0;
    public GameObject door;
    public GameObject win;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
           
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,-speed*Time.deltaTime,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if(keys == 3)
        {
            Destroy(door);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {//bounce the wall
        if (collision.gameObject.tag == "walls")
        {

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
               
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
        }



        if (collision.gameObject.tag == "keys")
        {
            keys++;
         
            Destroy(collision.gameObject);
        }


        if (collision.gameObject.tag == "enemies")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        

        if (collision.gameObject.tag == "win" )
        {

            Debug.Log( " You Won  !!!");

        }




    }
}
