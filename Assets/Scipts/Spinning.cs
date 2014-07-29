using UnityEngine;
using System.Collections;

public class Spinning : MonoBehaviour 
{
	public float initialSpeed;
	public bool enableSpin;
	private float timer;
	private Vector3 startingAngle;

	// MYOWNLERP
	private float elapsedTime;
	private float initTime;


	void Start()
	{
		startingAngle = transform.eulerAngles;
	}


	// Update is called once per frame before any physics calculations
	void FixedUpdate () 
	{
		if (enableSpin) 
		{
			Spin();
		}
	}

	public void Spin()
	{
		Vector3 origin = new Vector3 (0,0,0);
		Vector3 ZAxis = new Vector3 (0,0,1);
		transform.RotateAround (origin, ZAxis,Time.deltaTime * -calculateSpeed());
	}

	public void startSpin()
	{
		timer = 10f;
		initTime = Time.time;
		elapsedTime = 0f;
		transform.Rotate(startingAngle);

		enableSpin = true;
	}	

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
