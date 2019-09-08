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
		Line.SetPositions(new Vector3[]
			{
				transform.position,
				Crate.position
			});
	}
}
