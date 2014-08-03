using UnityEngine;
using System.Collections;

/*
 * class : Spinning
 * author(s) : Benjamin B. Mathieu
 *             Chali-Anne Lauzon
 * 
 * summary : This class is attached to our wheel and makes it spin.
 */
public class Spinning : MonoBehaviour 
{
	public float initialSpeed;
	public bool enableSpin;
	private float timer;

	// MYOWNLERP
	private float elapsedTime;
	private float initTime;

	/*
	 * Start()
	 * 
	 * We want to disable the spinning.
	 */
	void Start()
	{
		enableSpin = false;
	}


	/* Update()
	 * 
	 * The method is called once per frame before any physics calculations. Here we 
	 * make sure to make the wheel spin if the boolean has been set to true.
	 */
	void FixedUpdate () 
	{
		if (enableSpin) 
		{
			Spin();
		}
	}

	/*
	 * Spin()
	 * 
	 * Here we make the wheel spin around the z axis from the origin.
	 */
	public void Spin()
	{
		Vector3 origin = new Vector3 (0,0,0);
		Vector3 ZAxis = new Vector3 (0,0,1);
		transform.RotateAround (origin, ZAxis,Time.deltaTime * -calculateSpeed());
	}

	/*
	 * startSpin()
	 * 
	 * When we want the wheel to start spinning, we save the time and we want the wheel to be
	 * at it's initial position.
	 */
	public void startSpin()
	{
		timer = 10f;
		initTime = Time.time;      // Time since the begginning of the application.
		elapsedTime = 0f;

		// resets the rotation
		transform.rotation = Quaternion.identity;

		enableSpin = true;
	}	

	/*
	 * calculateSpeed()
	 * 
	 * This calculates the speed in a linear manner from the moment the sheel starts spinning.
	 * The result is the speed of the wheel. If it goes in the negatives, the wheel stops.
	 */
	private float calculateSpeed()
	{
		elapsedTime = Time.time - initTime;
		float result = -((initialSpeed)/timer)*elapsedTime + initialSpeed;

		if(result <= 0)
		{
			enableSpin = false;
		}

		return result;
	}
}
