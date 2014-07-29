using UnityEngine;
using System.Collections;

public class GameControllerMaster : MonoBehaviour 
{
	public playButton button;

	// Use this for initialization
	void Start () 
	{
		button = (playButton) GameObject.FindGameObjectWithTag("buttonStart").GetComponent(typeof(playButton));

	}
	
	// Update is called once per frame
	void Update () 
	{
		int i = 0;
		while (i < Input.touchCount) 
		{
			if (Input.GetTouch(i).phase == TouchPhase.Ended && button.IsInButton(Input.GetTouch(i).position))
			{
				// put button action here;
				Application.LoadLevel("main");
			}
				
			++i;
		}
    }

}
