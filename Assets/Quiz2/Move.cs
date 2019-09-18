using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public Rigidbody2D RB;
	public float MoveSpeed;

	private void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			RB.MovePosition(transform.position - new Vector3(MoveSpeed, 0f, 0f));
		}

		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			RB.MovePosition(transform.position + new Vector3(MoveSpeed, 0f, 0f));
		}
	}
}
