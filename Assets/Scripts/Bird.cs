using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour 
{
	public float upForce = 200f;

	private bool isDead = false;
	private Rigidbody2D rg2D;

	private Animator anim;

	public AudioClip flapSound;

	// Use this for initialization
	void Start () 
	{
		rg2D = GetComponent<Rigidbody2D> ();	
		anim = GetComponent<Animator> ();

		rg2D.AddForce (new Vector2(0, upForce + 100f)); // initial jump
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

				anim.SetTrigger ("Flap");
				SoundManager.instance.PlaySingle (flapSound);
			}
		}
	}

	void OnCollisionEnter2D()
	{
		rg2D.velocity = Vector2.zero;

		isDead = true;
		anim.SetTrigger ("Die");

		GameManager.instance.BirdDied ();
	}
}
