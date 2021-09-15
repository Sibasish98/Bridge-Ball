using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class playerr : MonoBehaviour {
	public bool gamePaused2 = false;
	adManagerr adm;
	GameObject gameAudio;
	//GameObject menuAudio;

	public GameObject cam,handler;
	public GameObject audioo;

	//UI handling objects
	public GameObject textBox;
	public TextMeshProUGUI highScor,scor;
	public Image backGp, trophy;
	public Button restartt,menuBt;
	CanvasRenderer cr;
	Image reButton,meBt;
	public bool gameOT = false;
	public int score = 0;
	float ttimer=0f;
	TextMeshProUGUI s,restartText,menuText;

	void Start()
	{
		//adm = GameObject.FindGameObjectWithTag ("admanager").GetComponent<adManagerr> ();
		//this.GetComponent<AudioSource> ().Play ();
		gameAudio = GameObject.FindGameObjectWithTag("gamemusic");
		//menuAudio = GameObject.FindGameObjectWithTag("menumusic");
		s = textBox.GetComponent<TextMeshProUGUI> ();
		backGp.enabled = false;
		reButton = restartt.GetComponent<Image> ();
		meBt = menuBt.GetComponent<Image> ();
		restartText = restartt.GetComponentInChildren<TextMeshProUGUI> ();
		menuText = menuBt.GetComponentInChildren<TextMeshProUGUI> ();
		menuBt.interactable = false;
		restartt.interactable = false;
	}
	void Update()
	{
		if (transform.position.y <= 0.4f ) {
				cam.GetComponent<camHandle> ().follow = false;
				handler.GetComponent<handle> ().sRotate = false;
				gameOT = true;
			}
			if (gameOT)
				ttimer = ttimer + Time.deltaTime;
			if (gameOT && ttimer > 0.7f) 
		{
			//if (adm.ia.IsLoaded ()) {
				//adm.ia.Show ();
			//}
				backGp.enabled = true;
				reButton.enabled = true;
				restartt.interactable = true;
				restartText.enabled = true;
				trophy.enabled = true;
				highScor.enabled = true;
				scor.enabled = true;
				scor.text = "YOUR SCORE  :  " + (score - 2).ToString ();
				meBt.enabled = true;
				menuText.enabled = true;
				menuBt.interactable = true;

				handleScore ();

		}
		if (score >= 2)
		s.text = (score-2).ToString ();
	}
	void OnCollisionEnter(Collision cc)
	{
		if (cc.gameObject.tag == "stablee") {
			Debug.Log ("coll");
			score++;
		}
	}
	public void restart()
	{
		gameAudio.GetComponent<AudioSource> ().Stop ();
		gameAudio.GetComponent<AudioSource> ().Play();
		//adm.RequestInterstatial ();
		SceneManager.LoadScene ("main");
	}
	public void menu()
	{
		gameAudio.GetComponent<AudioSource> ().Stop ();
		//menuAudio.GetComponent<AudioSource> ().Play ();
		//GameObject.FindGameObjectWithTag ("admanager").GetComponent<adManagerr> ().RequestBanner();
		//adm.RequestInterstatial ();
		SceneManager.LoadScene ("menu");
	}
	void handleScore()
	{
		if ((score - 2) > PlayerPrefs.GetInt ("highscore")) {
			PlayerPrefs.SetInt ("highscore", (score - 2));
		}
		highScor.text = "HIGH SCORE   :  " + PlayerPrefs.GetInt ("highscore");
	}
}
