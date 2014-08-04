using UnityEngine;
using System.Collections;

/*
 * class : GameControllerMaster
 * author(s) : Benjamin B. Mathieu
 *             Chali-Anne Lauzon
 * 
 * summary : This controller is located in the menu and is currently only used to
 *           load the application's only level.
 */
public class GameControllerMaster : MonoBehaviour 
{
	public playButton button;
	public GUIText titleText;

	/*
	 * Start()
	 * 
	 * We find the play button's script to start.
	 */
	void Start () 
	{
		button = (playButton) GameObject.FindGameObjectWithTag("buttonStart").GetComponent(typeof(playButton));
		titleText = (GUIText)GameObject.FindGameObjectWithTag ("titleGUI").GetComponent(typeof(GUIText));
	}
	
	/*
	 * Update()
	 * 
	 * Called once per frame, we use it to determine if one of the touch in one phase was over the play button.
	 * If yes, we load the level.
	 */
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
