using UnityEngine;
using System.Collections;

public class playButton : MonoBehaviour 
{

	private bool inButton;

	// Use this for initialization
	void Start () 
	{
		inButton = false;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public bool IsInButton(Vector2 touchPos)
	{
		Ray ray = Camera.main.ScreenPointToRay(touchPos);
		RaycastHit hitInfo;
		if (collider.Raycast(ray, out hitInfo, 1.0e8f))
		{
			inButton = !Physics.Raycast(ray, hitInfo.distance - 0.01f);
		}
		else
		{
			inButton = false;
		}

		return inButton;
	}
}
