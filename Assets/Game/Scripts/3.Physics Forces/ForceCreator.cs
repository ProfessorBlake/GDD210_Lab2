using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCreator : MonoBehaviour
{
	public float ForceStrength;
	public Rigidbody2D[] SceneRigidbodies; //An array of the RigidBody2Ds in the scene.

	private void Update()
	{
		//If we right click, apply a vertical force to our rigidbodies.
		if(Input.GetMouseButtonDown(1))
		{
			for(int i = 0; i < SceneRigidbodies.Length; i++)
			{
				SceneRigidbodies[i].AddForce(Vector2.up * ForceStrength);
			}
		}
	}
}
