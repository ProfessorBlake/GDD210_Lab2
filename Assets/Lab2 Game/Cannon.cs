using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
	public GameObject CannonBallPrefab;
	public Transform CannonRotTransform;
	public Transform CannonMainTransform;
	public float Rotation = 45;
	public float RotationSpeed = 40f;
	public Animator CannonAnimator;

	private void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
			Rotation += RotationSpeed * Time.deltaTime;
		else if (Input.GetKey(KeyCode.DownArrow))
			Rotation -= RotationSpeed * Time.deltaTime;

		CannonRotTransform.eulerAngles = new Vector3(0f, 0f, Rotation);

		if(Input.GetKeyDown(KeyCode.Space))
		{
			Fire();
		}
	}

	private void Fire()
	{
		GameObject ball = Instantiate(CannonBallPrefab, CannonMainTransform.position, Quaternion.identity);
		ball.GetComponent<Cannonball>().Launch(CannonMainTransform.right);
		CannonAnimator.SetTrigger("Fire");
	}
}
