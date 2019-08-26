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
		//Adding single impulses can be done in Update.
		if(Input.GetMouseButtonDown(1))
		{
			Debug.Log("Adding force!");
			for(int i = 0; i < SceneRigidbodies.Length; i++)
			{
				SceneRigidbodies[i].AddForce(Vector2.up * ForceStrength);
			}
		}
	}

	private void FixedUpdate()
	{
		//If we hold space, add a force opposite of gravity * mass. This should negate gravity and cause the rigidbody to float.
		//Any constant change added to physics should be done in FixedUpdate.
		if(Input.GetKey(KeyCode.Space))
		{
			for (int i = 0; i < SceneRigidbodies.Length; i++)
			{
				SceneRigidbodies[i].AddForce(SceneRigidbodies[i].mass * -Physics2D.gravity);
			}
		}
	}
}