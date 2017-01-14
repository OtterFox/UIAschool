using UnityEngine;
using System.Collections;

public class FPSMove : MonoBehaviour {

    public float speed= 0.01f;

	void Start ()
    {
	
	}
	

	void FixedUpdate ()
    {
        FlightCntrl();

    }

    void FlightCntrl()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
    }
}
