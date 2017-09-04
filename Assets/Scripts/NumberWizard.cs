using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// initialize variables where they'll be available to multiple methods
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	void StartGame () {
		 set variables at beginning of each game
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("=========================");
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me.");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		// alter max to allow choice of 1 or 1000
		max = max + 1;
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Please press: up arrow for higher, down arrow for lower, return for equal.");		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("up"))	{
			// print ("Up key was pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown("down"))	{
			// print ("Down key was pressed");
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown("return"))	{
			print ("I won!");
			StartGame ();
		}				
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess + "?");
		print ("Please press: up arrow for higher, down arrow for lower, return for equal.");
	}	
}
