using UnityEngine;
using System.Collections;

/*
 * class : exitButton
 * author(s) : Benjamin B. Mathieu
 *             Chali-Anne Lauzon
 * 
 * summary : This class brings us back to the menu if it had been clicked.
 */
public class exitButton : MonoBehaviour {


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

	/*
	 * isClicked()
	 * 
	 * We load the application's menu if the button has been clicked.
	 */
	public void isClicked()
	{
		Application.LoadLevel("menu");
	}
}
