using UnityEngine;
using System.Collections;

public class MainMenuManagerScript : MonoBehaviour {

	public MainMenuScript ActiveMenu;


	public void Start () 

	{
		DisplayMenu (ActiveMenu);
	}
	

	public void DisplayMenu(MainMenuScript mainMenuScript) 

	{
		if (ActiveMenu != null)
			ActiveMenu.IsOpen = false;

		ActiveMenu = mainMenuScript;
		ActiveMenu.IsOpen = true;
	}
}
