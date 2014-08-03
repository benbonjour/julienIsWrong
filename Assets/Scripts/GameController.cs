using UnityEngine;
using System.Collections;

/*
 * class : GameController
 * author(s) : Benjamin B. Mathieu
 *             Chali-Anne Lauzon
 * 
 * summary : This controller is responsible of the application's only scene. It makes the wheel spin and can
 *           bring us back to the menu.
 */
public class GameController : MonoBehaviour {

	private spinButton spinButtton_;
	private exitButton exitButton_;

	/*
	 * Start()
	 * 
	 * We first have to find our buttons' scripts.
	 */
	void Start () 
	{
		spinButtton_ = (spinButton)GameObject.FindGameObjectWithTag("spinButton").GetComponent(typeof(spinButton));
		exitButton_ = (exitButton)GameObject.FindGameObjectWithTag("exitButton").GetComponent(typeof(exitButton));
	}
	
	/*
	 * Update()
	 * 
	 * We check constantly for a touch close enough to the corresponding button. For each hit, we call the button's
	 * activation method.
	 */
	void Update () 
	{
		int i = 0;
		while (i < Input.touchCount) 
		{
			if (Input.GetTouch(i).phase == TouchPhase.Ended && spinButtton_.IsInButton(Input.GetTouch(i).position))
			{
				spinButtton_.isClicked();
            }
			if (Input.GetTouch(i).phase == TouchPhase.Ended && exitButton_.IsInButton(Input.GetTouch(i).position))
			{
				exitButton_.isClicked();
            }
            
            ++i;
        }
    }
}
