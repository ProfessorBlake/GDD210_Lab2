using UnityEngine;
using UnityEngine.UI;

public class BounceManager : MonoBehaviour
{
	public Text BounceText;
	public int BounceCount;

	public void AddBounce(int bounces)
	{
		BounceCount += bounces;
		BounceText .text= "Bounces" + BounceCount.ToString();
	}
}
