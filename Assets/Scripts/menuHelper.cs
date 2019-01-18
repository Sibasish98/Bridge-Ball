using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class menuHelper : MonoBehaviour {
	//for rate and share button view disable
	public Button rate,share;
	Image ratei,sharei;
	public Image rateIcon, shareIcon;


	bool helpOpened = false;
	public Image helpWindowsbackground;
	public TextMeshProUGUI contents;
	public Image title;
	// Use this for initialization
	void Start () 
	{
		//for 2 buttons
		ratei = rate.GetComponent<Image>();
		sharei = share.GetComponent<Image> ();


		/*if (helpOpened) {
			helpWindowsbackground.enabled = false;
			contents.enabled = false;
			title.enabled = false;
		}*/
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if (helpOpened) {
				helpWindowsbackground.enabled = false;
				contents.enabled = false;
				title.enabled = true;
				//for rate and share button
				rate.enabled = true;
				ratei.enabled = true;
				rateIcon.enabled = true;
				share.enabled = true;
				sharei.enabled = true;
				shareIcon.enabled = true;
			}
		}
	}
	public void openHelpWindow()
	{
		helpOpened = true;
		helpWindowsbackground.enabled = true;
		contents.enabled = true;
		title.enabled = false;
		//for rate and share button
		rate.enabled = false;
		ratei.enabled = false;
		rateIcon.enabled = false;
		share.enabled = false;
		sharei.enabled = false;
		shareIcon.enabled = false;
    }
}