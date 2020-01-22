using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Transform tf;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move up if the player presses up
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            //Only works if shift is held down.

        }
        else
        {
            //Only works if shift is not held down.

            // Movement for going up
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position = tf.position + (Vector3.up * Time.deltaTime * speed);
            }
            //Movement for going left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position = tf.position + (Vector3.left * Time.deltaTime * speed);
            }
            //Movement for going down
            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position = tf.position + (Vector3.down * Time.deltaTime * speed);
            }
            //Movement for going right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position = tf.position + (Vector3.right * Time.deltaTime * speed);
            }
        }
        //This works if the player is holding down shift or ISN'T holding shift
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = new Vector3(0, 0, 0);
        }
    }
}