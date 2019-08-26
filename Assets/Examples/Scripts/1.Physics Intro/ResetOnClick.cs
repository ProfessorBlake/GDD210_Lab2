using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is designed to be reusable, so that any gameobject we attach it to will reset its position and velocity when we click.
//Think about writing reusable code when you work, it saves time and is usually more effecient.
public class ResetOnClick : MonoBehaviour
{
	public Rigidbody2D Rigidbody;

	private Vector2 startPosition;

	private void Start()
	{
		startPosition = transform.position;
	}

	private void Update()
    {
		//Reset this objects position and velocity when the mouse is clicked.
		if (Input.GetMouseButtonDown(0))
		{
			transform.position = startPosition;
			Rigidbody.velocity = Vector2.zero;
			Rigidbody.angularVelocity = 0f;
		}
    }
}
