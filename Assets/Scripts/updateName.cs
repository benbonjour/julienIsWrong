using UnityEngine;
using System.Collections;

/*
 * class : updateName
 * author(s) : Benjamin B. Mathieu
 *             Chali-Anne Lauzon
 * 
 * summary : This class sets the chosen one's name if it is different from the default message.
 */
public class updateName : MonoBehaviour {

	private GameControllerMaster master_;

	private TextMesh titleTextMesh_;

	/*
	 * Start()
	 * 
	 * We find the menu's controller.
	 */
	void Start () 
	{
		master_ = (GameControllerMaster)GameObject.FindGameObjectWithTag (Tags.menuController).GetComponent (typeof(GameControllerMaster));

		titleTextMesh_ = (TextMesh) gameObject.GetComponent (typeof(TextMesh));

		if(master_.isNameSet())
		{
			titleTextMesh_.text = "Is Julien wrong?";
		}
	}
	
	/*
	 * Update()
	 * 
	 * We check the name again and again.
	 */
	void Update () 
	{
		if(master_.isNameSet())
		{
			titleTextMesh_.text = "Is Julien wrong?";
		}
		else
		{
			titleTextMesh_.text = "Is " + master_.getName() + "wrong?";
		}
	}
}
