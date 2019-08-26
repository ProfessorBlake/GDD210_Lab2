using UnityEngine;

public class CollisionTester : MonoBehaviour
{
	public BounceManager BounceManager;

	//Any collider2D component will call this function on
	//any attached scripts.
	private void OnCollisionEnter2D(Collision2D collision)
	{
		BounceManager.AddBounce(1);
	}
}
