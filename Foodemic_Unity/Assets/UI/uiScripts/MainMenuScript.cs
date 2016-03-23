using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	private Animator menuAnimator;
	private CanvasGroup menuCanvasGroup;

	public bool IsOpen 
	{
		get { return menuAnimator.GetBool ("IsOpen"); }
		set { menuAnimator.SetBool ("IsOpen", value); }
	}


	public void Awake () 
	{
		menuAnimator = GetComponent<Animator> ();
		menuCanvasGroup = GetComponent<CanvasGroup> ();

		var rect = GetComponent<RectTransform> ();
		rect.offsetMax = rect.offsetMin = new Vector2 (0, 0);
	}

	void Update () 
	{
		if (!menuAnimator.GetCurrentAnimatorStateInfo (0).IsName ("Open")) {
			menuCanvasGroup.blocksRaycasts = menuCanvasGroup.interactable = false;
		} 
		else 
		{
			menuCanvasGroup.blocksRaycasts = menuCanvasGroup.interactable = true;
		}
	}
}
