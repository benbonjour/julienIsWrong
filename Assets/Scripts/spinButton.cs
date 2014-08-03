using UnityEngine;
using System.Collections;

/*
 * class : spinButton
 * author(s) : Benjamin B. Mathieu
 *             Chali-Anne Lauzon
 * 
 * summary : This class activates the wheel through a 3D object that we use like a button.
 */
public class spinButton : MonoBehaviour 
{
	public GameObject wheel;
	private Spinning wheelSpin;
	private bool inButton;

	/* Start()
	 * 
	 * We find our wheel and the script that'll make it spin.
	 */
	void Start () 
	{
		wheel = GameObject.Find ("wheel");
		wheelSpin = (Spinning) wheel.GetComponent(typeof(Spinning));

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
	 * If it's been found that the user's touch was on the button, we activate the wheel only if
	 * it is not currently spinning.
	 */
	public void isClicked()
	{
		if (!wheelSpin.enableSpin) 
		{
			wheelSpin.startSpin ();
		}
	}
}
