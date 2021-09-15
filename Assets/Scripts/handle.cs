using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class handle : MonoBehaviour {
	//Training event hanlers variable
	public Toggle showTutorialchc;
	public TextMeshProUGUI showTutorialText;
	public Image showTutorialBackground;
	public Image checkMark;
	//button ok
	public Button trainOKbt;
	Image okimg;
	public TextMeshProUGUI trainOkText;

	bool training = false;
	bool gamePaused = false;
	bool resumeStarted = false;
	float resumeTimmer = 4f;
	public Image screenDim;
	public TextMeshProUGUI pauseText;
	//componenets of pase button and pause btton's text
	public Button pauseBt;
	Image pauseBtImage;
	public TextMeshProUGUI pauseBtTExt;

	camHandle ch;
	public TextMeshProUGUI rotateLeftT, rotateRightT;
	public Image leftRotate, rightRotate;
	float trainAppear = 0f;
	bool activee = false;
	public GameObject playerr;
	playerr pl;


	public GameObject walkable,inter;
	public bool sRotate = true;
	bool direction = false;
	float controlSpeed = 80f;
	GameObject[] ju=new GameObject[1000];
	GameObject[] w = new GameObject[1000];
	float currentY = 1.5f;
	void Start () 
	{
		okimg = trainOKbt.GetComponent<Image> ();
		//PlayerPrefs.SetInt ("newgame", 0);   //Debug purpose , force write each session is anew game 
		ch = Camera.main.GetComponent<camHandle> ();
		pl = playerr.GetComponent<playerr> ();
		pauseBtImage = pauseBt.GetComponent<Image> ();
	    for (int i = 0; i < 1000; i++) 
		{
			currentY += 1.6f;
			w[i]=Instantiate (walkable, new Vector3 ( 0,0,currentY),Quaternion.identity);
			w [i].transform.rotation = Quaternion.identity;
			w [i].GetComponent<Renderer> ().material.SetColor ("_EmissionColor", new Color32((byte)Random.Range (10, 20), (byte)Random.Range (10, 20), (byte)Random.Range (10,20),0));
			currentY += 1.6f;
			ju[i] = Instantiate (inter, new Vector3 ( 0,0.33f,currentY), Quaternion.Euler(new Vector3(0,Random.Range(1,180),0)));

		}
		if (PlayerPrefs.GetInt ("newgame") == 0) {
			train ();
		}
	}
	void train()
	{
		training = true;
		checkMark.enabled = true;
		if (trainAppear >= 1.5f) {
			training = true;
			showTutorialchc.enabled = true;
			showTutorialText.enabled = true;
			showTutorialBackground.enabled = true;
			//button ok
			trainOKbt.enabled = true;
			okimg.enabled = true;
			trainOkText.enabled = true;

			training = true;
			ch.training1 = true;
			activee = true;
			rotateLeftT.enabled = true;
			rotateRightT.enabled = true;
			leftRotate.enabled = true;
			rightRotate.enabled = true;
			//if (Input.GetMouseButtonDown (0)) {
				
			//}
		}

	}
	void Update () 
	{
		if (pl.gameOT) {
			pauseBt.enabled = false;
			pauseBtImage.enabled = false;
			pauseBtTExt.enabled = false;
		}

		if (training) {
			train ();
			trainAppear = trainAppear + Time.deltaTime;
			Debug.Log (trainAppear);
		}
		Debug.Log (trainAppear);
		if (gamePaused) 
		{
			pauseButtonPress ();
		}


		handleInput ();
		if (!activee && !gamePaused) {
			controlSpeed += 0.09f;
			//	Debug.Log (controlSpeed);
			if (direction && sRotate) {
				for (int j = 0; j < pl.score + 1; j++) {
					ju [j].transform.Rotate (new Vector3 (0, controlSpeed * Time.deltaTime, 0));
				}
			}
			if (!direction && sRotate) {
				for (int j = 0; j < pl.score + 1; j++) {
					ju [j].transform.Rotate (new Vector3 (0, -(controlSpeed * Time.deltaTime), 0));
				}
			}
		}
	}
	void handleInput()
	{
		if (Input.GetMouseButtonDown (0)) {
			if (Input.mousePosition.x > Screen.width / 2) {
				direction = true;
			} else if (Input.mousePosition.x < Screen.width/2)
				direction = false;
			if (Input.touchSupported) {
				if (Input.touches [0].position.x > Screen.width / 2) {
					direction = true;
				} else if (Input.touches [0].position.x < Screen.width / 2) {
					direction = false;
				}
			}
		}
		//keyboard control
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			direction = false;
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			direction = true;
		}
	}
	//called when pause button is clicked
	public void pauseButtonPress()
	{
		if (!pl.gameOT) {
		gamePaused = true;
		ch.gamePaused1 = true;
		pl.gamePaused2 = true;
		screenDim.enabled = true;
		pauseText.enabled = true;
		pauseText.text = "Tap to resume";
		if (!resumeStarted)
		pauseBt.enabled = false;
		pauseBtImage.enabled = false;
		pauseBtTExt.enabled = false;
		if (Input.GetMouseButtonDown (0)) {
			resumeStarted = true;
			pauseText.enabled = true;
		}
		if (resumeStarted) {

				resumeTimmer = resumeTimmer - Time.deltaTime;
				pauseText.text = "         " + ((int)resumeTimmer).ToString ();
				//check resume timmer limit
				if (resumeTimmer < 1) {
					resumeTimmer = 4f;
					resumeStarted = false;
					gamePaused = false;
					ch.gamePaused1 = false;
					//changes in UI elements
					screenDim.enabled = false;
					pauseText.enabled = false;
					pauseBt.enabled = true;
					pauseBtImage.enabled = true;
					pauseBtTExt.enabled = true;
					pl.gamePaused2 = false;
				}
			}
		}
		if (pl.gameOT) {
			pauseText.text = "";
			screenDim.enabled = false;
		}
	}
	public void trainButtonClicked()
	{
		showTutorialchc.enabled = false;
		showTutorialText.enabled = false;
		showTutorialBackground.enabled = false;
		//button ok
		trainOKbt.enabled = false;
		checkMark.enabled = false;
		okimg.enabled = false;
		trainOkText.enabled = false;

		rotateLeftT.enabled = false;
		rotateRightT.enabled = false;
		leftRotate.enabled = false;
		rightRotate.enabled = false;
		training = false;
		ch.training1 = false;
		activee = false;
		if (showTutorialchc.isOn)
		PlayerPrefs.SetInt ("newgame", 1);
	}
}
