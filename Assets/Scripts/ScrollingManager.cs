using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingManager : MonoBehaviour 
{
	private Rigidbody2D rg2D;
	// Use this for initialization
	void Start () 
	{
		rg2D = GetComponent<Rigidbody2D> ();
		//rg2D.velocity = new Vector2 (GameManager.instance.scrollSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		rg2D.velocity = new Vector2 (GameManager.instance.scrollSpeed, 0);
		if (GameManager.instance.gameOver == true) 
		{
			rg2D.velocity = Vector2.zero;
		}	
	}
}
