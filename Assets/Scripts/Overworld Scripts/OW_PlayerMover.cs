using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OW_PlayerMover : MonoBehaviour {

    private Vector3 position;
    private Vector3 direction;

	// Use this for initialization
	void Start () {
        //Input.GetButton
        position = gameObject.transform.position;
        direction = new Vector3(0f, -1f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        position = gameObject.transform.position;
        Vector3 input;
        if (Input.GetButtonDown(KeyCode.D.ToString()))
        {
            Debug.Log("udios");
            //if()
        }

    }

    //takes a direction string and returns a vector
    Vector3 directionToVector(string dir)
    {

        if (dir == "LEFT")
        {
            return new Vector3(-1f, 0f, 0);
        }

        if (dir == "RIGHT")
        {
            return new Vector3(1f, 0f, 0);
        }

        if (dir == "DOWN")
        {
            return new Vector3(0f, -1f, 0);
        }
        if (dir == "UP")
        {
            return new Vector3(0f, 1f, 0);
        }

        return Vector3.zero;

    }

    //takes a direction Vector and returns a direction string
    string VectorToDirection(Vector3 dir)
    {

        if (dir == Vector3.left)
        {
            return "LEFT";
        }

        if (dir == Vector3.right)
        {
            return "RIGHT";
        }

        if (dir == Vector3.down)
        {
            return "DOWN";
        }
        if (dir == Vector3.up)
        {
            return "UP";
        }

        return "DOWN";

    }

    private void OnRenderObject()
    {
        Debug.DrawRay(position, direction, Color.green, 5f);
    }
}
