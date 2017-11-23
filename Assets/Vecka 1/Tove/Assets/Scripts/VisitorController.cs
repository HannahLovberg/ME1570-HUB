using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorController : MonoBehaviour
{
    public float Speed;

    public bool CanMove;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(Vector2.right * Speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector2.right * Speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector2.up * Speed);
        }
    }
}
