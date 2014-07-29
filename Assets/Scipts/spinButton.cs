using UnityEngine;
using System.Collections;

public class spinButton : MonoBehaviour 
{

	
	public GameObject wheel;
	private Spinning wheelSpin;
	private bool inButton;

	// Use this for initialization
	void Start () 
	{
		wheel = GameObject.Find ("wheel");
		wheelSpin = (Spinning) wheel.GetComponent(typeof(Spinning));

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

	public void isClicked()
	{
		wheelSpin.startSpin();
	}
}
