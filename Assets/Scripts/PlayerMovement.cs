using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Button yourLeftButton;
    public Button yourRightButton;

    private float speed = 10f;
    public Rigidbody animal;

    void Awake() //very first function called when game is on
    {

        //animal = GetComponent<Rigidbody>();
        Button btnL = yourLeftButton.GetComponent<Button>();
        Button btnR = yourRightButton.GetComponent<Button>();
        btnL.onClick.AddListener(MoveLeft);
        btnR.onClick.AddListener(MoveRight);
        
        if (Menu.clickedButton == 1)
        {
            //animal = Rigidbody.Find("ScoreText");
        }

    }


    void FixedUpdate()
    {
        Vector3 vel = animal.velocity;
        vel.x = Input.GetAxis("Horizontal") * speed;
        animal.velocity = vel;

        float right = Input.GetAxis("Horizontal")/speed;// * speed;
;
        animal.position = new Vector3(animal.position.x + right, animal.position.y, animal.position.z);

        //print (Input.GetAxis("Horizontal"));
    }

    void MoveLeft()
    {
        //animal.position = new Vector3(animal.position.x - 1f, animal.position.y, animal.position.z);
        transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
    }

    void MoveRight()
    {
        //animal.position = new Vector3(animal.position.x + 1f, animal.position.y, animal.position.z);
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
