using UnityEngine;
using System.Collections;

public class FPSAim : MonoBehaviour {

    float mouseX;
    float mouseY;

    bool isInverted;

	void Start ()
    {
	
	}
	
	
	void Update ()
    {
        MousPos();
        Inverted();
    }

   public void MousPos()
    {
        mouseX += Input.GetAxis("Mouse X");
        if(isInverted)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y"); //view up/down w/out -= up/down would be reversed
        }
       
        print(mouseX);
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }

    void Inverted() //inverts up/down
    {
        if(!isInverted && Input.GetKey(KeyCode.P))
        {
            isInverted = true;
            print("mouseY Inverted");
        }
        else if (isInverted && Input.GetKey(KeyCode.P))
        {
            isInverted = false;
            print("mouseY is NOT Inverted");
        }
        else
        {
            print("Something went wrong, does up/down work?");
        }
    }


}
