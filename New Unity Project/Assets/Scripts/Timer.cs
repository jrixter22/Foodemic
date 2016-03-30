using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
	public int playtime = 120;//manipulate time and used to store later in playerprefs
	private int seconds = 0;//keeps track of seconds
	private int minutes = 0;//keeps track of minutes
	
	void Start ()
	{
		//starts the countdown for the timer
		StartCoroutine ("Playtimer");
	}
	
	private IEnumerator Playtimer()
	{
		while (true)
		{
			//after a second, the playtime decrements by 1 and the minute and second reset after reaching 60
			yield return new WaitForSeconds(1); //waits a second
			playtime -= 1;
			seconds = (playtime % 60);
			minutes = (playtime / 60) % 60;
			if(minutes == 0 && seconds == 0)
			{
				Debug.Log("Stop");
				break;
			}
		}
	}
	
	void Update ()
	{
		//shows the timer on the screen
		if (seconds > 9) 
		{
			Debug.Log ("Time: " + minutes.ToString () + " : " + seconds.ToString ());
		} 
		else
		{
			Debug.Log ("Time: " + minutes.ToString () + " : 0" + seconds.ToString ());
		} 
		/*else 
		{
			Debug.Log("Stop");
		}*/
	}
	
}
