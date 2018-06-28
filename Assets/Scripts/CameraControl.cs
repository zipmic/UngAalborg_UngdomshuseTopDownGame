using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        //   offset = transform.position - player.transform.position;
        offset = new Vector3(0, 8, -10);
    }
    void Update()
    {
        
    }
    // Update is called once per frame
    void LateUpdate () {
        transform.position = player.transform.position + offset;
       // if (Input.GetKey(KeyCode.E))
       // {
       //     transform.Rotate(5.0f, 0.0f, 0.0f);
      //  }

        if(Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(player.transform.position, 50*Time.deltaTime);
        }


    }
}
