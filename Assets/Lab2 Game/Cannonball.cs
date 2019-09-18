using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
	public Rigidbody2D RB;
	public float LaunchForce;
	public Vector2 LaunchAngle;

	public void Launch(Vector2 angle)
	{
		LaunchAngle = angle;
		RB.velocity = LaunchAngle.normalized * LaunchForce;
	}
}
