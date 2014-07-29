using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private spinButton spinButtton_;
	private exitButton exitButton_;

	// Use this for initialization
	void Start () 
	{
		spinButtton_ = (spinButton)GameObject.FindGameObjectWithTag("spinButton").GetComponent(typeof(spinButton));
		exitButton_ = (exitButton)GameObject.FindGameObjectWithTag("exitButton").GetComponent(typeof(exitButton));
	}
	
	// Update is called once per frame
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
