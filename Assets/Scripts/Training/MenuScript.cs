using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
//	void OnGUI()
//	{
//		const int buttonWidth = 84;
//		const int buttonHeight = 60;
//
//		//Draw a button to start game
//		if (
//			GUI.Button (
//				//Center in X, 2/3 of the height in Y
//				new Rect (
//					(Screen.width / 2) - (buttonWidth / 2),
//					(2 * Screen.height / 3) - (buttonHeight / 2),
//					buttonWidth,
//					buttonHeight),
//				"Start!"
//			)) {
//			// On Click, Load the first level.
//			// "CheesyRobot" is the name of the first scene we created.
//			Application.LoadLevel ("CheesyRobot");}
//	}

	public void CheesyRobotLoad(){
		SceneManager.LoadScene ("CheesyRobot");
	}
	public void MainScreenLoad(){
		SceneManager.LoadScene ("MainScreen");
	}
}