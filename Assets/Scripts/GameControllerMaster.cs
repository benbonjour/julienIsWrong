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
	public int fontSize = 36;

	private string nameField = "Enter a name";

	private GUIStyle biggerFontSize;

	/*
	 * Start()
	 * 
	 * We find the play button's script to start.
	 */
	void Start () 
	{	
		button = (playButton) GameObject.FindGameObjectWithTag("buttonStart").GetComponent(typeof(playButton));
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

	/*
	 * createGUIStyle()
	 * 
	 * This sets up the GUI as to have a pretty input text.
	 */
	void createGUIStyle()
	{
		biggerFontSize = new GUIStyle(GUI.skin.textField);

		biggerFontSize.fontSize = fontSize;
		biggerFontSize.normal.textColor = Color.white;
	}

	/*
	 * OnGUI()
	 * 
	 * Not really sure how it works yet. One thing we know is that it is called many times per frame.
	 */
	void OnGUI()
	{
		// MUST BE HERE OTHERWISE BLANK
		createGUIStyle ();

		// I decided to use ratios to position the text field.
		nameField = GUI.TextField (new Rect(Screen.width * 1/5,
		                                    Screen.height* 4/5 ,
		                                    Screen.width * 3/5, 
		                                    Screen.height * 1/12 ), 
		                           nameField, 
		                           30,
		                           biggerFontSize);
	}

	/*
	 * getName()
	 * 
	 * Returns the name entered in the text field.
	 */
	public string getName()
	{
		return nameField;
	}

}
