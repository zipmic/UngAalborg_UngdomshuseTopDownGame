using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Camera MainCamera;
    private Rigidbody rb;
    public GameObject PlayerGraphic;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        Vector3 targetDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            targetDirection = (transform.position-Camera.main.transform.position);
            targetDirection.y = 0;
            targetDirection.Normalize();
            //targetDirection = Camera.main.transform.TransformDirection(Vector3.forward).normalized;
        }
        else if(Input.GetKey(KeyCode.A))
        {
          
            targetDirection = Camera.main.transform.right*-1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            targetDirection = Camera.main.transform.right;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            targetDirection = (transform.position - Camera.main.transform.position)*-1;
            targetDirection.y = 0;
            targetDirection.Normalize();
       
        }

        targetDirection.y = rb.velocity.y;
        rb.velocity = targetDirection * Time.deltaTime * speed;


        if(targetDirection != Vector3.zero)
        {
            PlayerGraphic.transform.rotation = Quaternion.Slerp(PlayerGraphic.transform.rotation, Quaternion.LookRotation(targetDirection), 0.15F);
        }




        //print(targetDirection);

     
       

  
    }
        
}
