using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance = null;
	public GameObject gameOverText;
	public bool gameOver = false;
	public Text scoreText;
	public float scrollSpeed = -1.5f;

	private int score = 0;

	// Use this for initialization
	void Awake () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameOver == true && Input.GetMouseButtonDown (0)) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}	
	}

	public void BirdScored()
	{
		if (gameOver)
			return;

		score++;
		IncreaseSpeed ();
		
		scoreText.text = "Pontos: " + score.ToString();
	}

	public void BirdDied()
	{
		gameOverText.SetActive (true);
		gameOver = true;
	}

	public void IncreaseSpeed()
	{
		if ((score%5) == 0)
			scrollSpeed += -0.5f; // increase speed
	}
}
