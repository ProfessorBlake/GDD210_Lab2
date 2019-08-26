using UnityEngine;

public class CollisionTester : MonoBehaviour
{
	public BounceManager BounceManager;

	//Any Collider2D component will call this function on
	//any attached scripts when the collider enters a collision with another collider.
	//The gameobject must also have a RigidBody2D attached.
	private void OnCollisionEnter2D(Collision2D collision)
	{
		BounceManager.AddBounce(1);
	}
}
