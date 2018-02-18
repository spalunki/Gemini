using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaMovement : MonoBehaviour {

    public NinjaCamera cam;

    public Vector3 position, velocity, heading;

    [Range(0f,0.5f)]
    public float speed;
    [Range(0.5f,2f)]
    public float runSpeed;

	// Use this for initialization
	void Start () {

        position = gameObject.transform.position;
        heading = Vector3.forward;
        velocity = new Vector3();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("x: " + Input.GetAxisRaw("Horizontal") + " & y:" + Input.GetAxisRaw("Vertical"));

        getInput();                
        calcForces();
        orient();
	}
    
    //returns a Vector3 with input info
    void getInput()
    {
        

        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.z = Input.GetAxisRaw("Vertical");


        //velocity *= Time.deltaTime;
        //update heading vector
        if (velocity != Vector3.zero)
        {
            heading = velocity;
            heading.Normalize();
        }

        //check if player is running
        if(velocity!=Vector3.zero)
        {
            if (Input.GetKey(KeyCode.F))
                velocity *= (runSpeed / velocity.magnitude);
            else
                velocity *= (speed / velocity.magnitude);
        }
        
    }

    void orient()
    {
        gameObject.transform.rotation = Quaternion.LookRotation(heading);
    }

    //applies changes
    void calcForces()
    {
        //velocity *= 0.8f;
        transform.position += velocity;        
        //transform.position = position;
    }
}
