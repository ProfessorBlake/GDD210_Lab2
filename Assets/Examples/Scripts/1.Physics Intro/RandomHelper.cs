using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHelper : MonoBehaviour
{
	public string Word;
	public Vector2 Vec2;
	public string[] Strings;


    void Start()
    {
		///Random.value
		///This will return a random float between 0 - 1.
		///You can use this in conditional statements to perfom random chance checks.
		float randValue = Random.value;
		Debug.Log("Random value: " + randValue);

		//This will simulate flipping a coin, since we have a 50% chance of randValue being greater than 0.5f
		Debug.Log("Coin flip: ");
		if(randValue > 0.5f)
		{
			Debug.Log("Heads!");
		}
		else
		{
			Debug.Log("Tails!");
		}

		//=====================================================================================
		///Random.Range
		///This can be used to return a value between two numbers.
		///
		/// If you pass integers in, it will return an int between the numbers. This is exclusive, meaning it the number it returns will be, at most, one
		/// less than the second number you enter.
		/// 
		///If you pass floats in, it will return a float between the numbers, and is inclusive, meaning it can return the second number you pass.

		Debug.Log("Random Int: ");
		Debug.Log(Random.Range(0, 50)); //This will return an int between 1 and 49.

		Debug.Log("Random Float: ");
		Debug.Log(Random.Range(0f, 100f)); //This will return a float between 0 and 100.

		//=====================================================================================
		///Using Random

		Debug.Log("Random letter: " + Word.Substring(Random.Range(0, Word.Length), 1)); //This will print a random letter from a word.
		Debug.Log("Random float in Vec2: " + Random.Range(Vec2.x, Vec2.y)); //This will print a float between the X and Y values of Vec2.
		Debug.Log("Random word: " + Strings[Random.Range(0, Strings.Length)]); //This will pring a random string from the Strings array.

		for(int i = 0; i < Random.Range(4,8); i++) //This loop will run a random number of times.
		{
			Debug.Log("For Loop!");
		}
	}
}
