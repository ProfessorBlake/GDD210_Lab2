using UnityEngine;
using UnityEngine.UI;

public class BounceManager : MonoBehaviour
{
	public Text BounceText;
	public int BounceCount;

	//Public functions can be called from other scripts, as long as they have a reference to an instance of this class.
	//In AddBounce, we take an int as a parameter, and add that to our BounceCount variable.
	public void AddBounce(int bounces)
	{
		BounceCount += bounces;
		BounceText .text= "Bounces" + BounceCount.ToString();
	}
}
