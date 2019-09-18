using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
	public Rigidbody2D RigidBody;

	private int bounces;
	private Vector3 startPos;

	private void Start()
	{
		startPos = transform.position;
	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			bounces = 0;
			transform.position = new Vector3(Random.Range(-3f,3f), 5f);
			RigidBody.velocity = Vector3.zero;
			RigidBody.AddForce(new Vector2(Random.Range(-160f, 160f), Random.Range(25f, 100f)));
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		bounces++;
		Debug.Log("Bounces: " + bounces);
	}
}
