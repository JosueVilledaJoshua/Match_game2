using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    void Start()
    {
        //transform.position = new Vector3(0, 0, 0);
    }


    void Update()
    {
        MoveHorizontal();
    }

    //Fir 2 player, stablish 2 different scripts for individual commands
    //Now has horizontal for testing purposes
    public void MoveHorizontal()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

    }
}
