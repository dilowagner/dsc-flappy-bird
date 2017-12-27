using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour 
{
	public float upForce = 200f;

	private bool isDead = false;
	private Rigidbody2D rg2D;

	// Use this for initialization
	void Start () 
	{
		rg2D = GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isDead == false) 
		{
			if (Input.GetMouseButtonDown (0)) 
			{
				rg2D.velocity = Vector2.zero;
				rg2D.AddForce (new Vector2(0, upForce));
			}
		}
	}

	void OnCollisionEnter2D()
	{
		isDead = true;
	}
}
