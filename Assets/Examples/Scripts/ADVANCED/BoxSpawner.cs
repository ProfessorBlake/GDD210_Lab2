using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
	public GameObject BoxPrefab;

	private float spawnDelay = 0;
	private float spawnDelayReset = 1f; //How long to delay between instantiating boxes.
	private List<GameObject> boxList = new List<GameObject>(); //A list of all the boxes we instantiate.

	public void Update()
	{
		spawnDelay -= Time.deltaTime; //Subtract the time in seconds since the last Update() was run.
		
		if(boxList.Count > 10) //Remove our boxes if we have more than 10.
		{
			foreach(GameObject box in boxList)
			{
				Destroy(box);
			}
			boxList.Clear(); //Clear the list.
		}

		if(spawnDelay <= 0f) //Check if we should spawn a new box.
		{
			spawnDelay = spawnDelayReset; //Reset the delay.
			GameObject newBox =  Instantiate(BoxPrefab, new Vector3(0f, 6f, 0f), Quaternion.Euler(new Vector3(0f, 0f, Random.Range(0f, 360f)))); 
			// ^ Create a new GameObject, which is a copy of BoxPrefab. Set a new variable 'newBox' to this copy.
			//Create it at (0,6,0) in the world, with a random rotation on the Z axis.

			newBox.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-200f, 200f); //Give the boxes Rigidbody2D component some spin.
			boxList.Add(newBox); //Add our new box to our box list.
		}
	}
}
