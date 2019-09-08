using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
	public LineRenderer Line;
	public Transform Crate;

	private void Start()
	{
		Line.SetPositions(new Vector3[]
			{
				transform.position,
				Crate.position
			});
	}

	private void FixedUpdate()
	{
		//Because the line renderer uses an array of Vector3 for it's position data, we need to update them whenever our gameobject moves.
		//Since our crates are physics objects, they'll only move on FixedUpdate frames, so we don't need to change their position in Update.
		Line.SetPositions(new Vector3[]
			{
				transform.position,
				Crate.position
			});
	}
}
