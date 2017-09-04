using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me.");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Please press: up arrow for higher, down arrow for lower, return for equal.");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("up"))	{
			// print ("Up key was pressed");
			min = guess;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown("down"))	{
			// print ("Down key was pressed");
			max = guess;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown("return"))	{
			print ("I won!");
		}				
	}
}
