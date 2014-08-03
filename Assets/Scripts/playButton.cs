using UnityEngine;
using System.Collections;

/*
 * class : playButton
 * author(s) : Benjamin B. Mathieu
 *             Chali-Anne Lauzon
 * 
 * summary : This class checks if the 3D object has been touched by the user.
 */
public class playButton : MonoBehaviour 
{

	private bool inButton;

	/*
	 * Start()
	 * 
	 * Initially it is not touched.
	 */
	void Start () 
	{
		inButton = false;
	}

	/*
	 * IsInButton()
	 * 
	 * We check if the user's touch was over our button object, with a small margin.
	 */
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
