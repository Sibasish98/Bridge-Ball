using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour {
	int lowerLimit=0,upperLimit=3;



	GameObject menuAudio,gameAudio;


	public GameObject walkable,inter;
	public bool sRotate = true;
	bool direction = false;
	GameObject[] ju=new GameObject[1000];
	GameObject[] w = new GameObject[1000];
	float currentY = 1.5f;
	void Start () 
	{
		gameAudio = GameObject.FindGameObjectWithTag("gamemusic");
		menuAudio = GameObject.FindGameObjectWithTag("menumusic");
		DontDestroyOnLoad (gameAudio);
		DontDestroyOnLoad (menuAudio);
		menuAudio.GetComponent<AudioSource> ().Play ();
		Debug.Log ("it should not be");
		for (int i = 0; i < 1000; i++) 
		{
			currentY += 1.6f;
			w[i]=Instantiate (walkable, new Vector3 ( 0,0,currentY),Quaternion.identity);
			w [i].transform.rotation = Quaternion.identity;
			w [i].GetComponent<Renderer> ().material.SetColor ("_EmissionColor", new Color32((byte)Random.Range (50, 80), (byte)Random.Range (50, 80), (byte)Random.Range (50,80),0));
			currentY += 1.6f;
			ju[i] = Instantiate (inter, new Vector3 ( 0,0.33f,currentY), Quaternion.Euler(new Vector3(0,Random.Range(1,180),0)));

		}
	}
	void Update () 
	{

		//	Debug.Log (controlSpeed);
		if (!direction && sRotate) {
			for (int j = 0; j < upperLimit; j++) {
				ju [j].transform.Rotate (new Vector3 (0, 80f * Time.deltaTime, 0));
			}
		}
		if (direction && sRotate) 
		{
			for (int j = 0; j < upperLimit; j++) {
				ju [j].transform.Rotate (new Vector3 (0, -(80f * Time.deltaTime),0));
			}
		}
		lowerLimit = lowerLimit + 1;
		upperLimit = upperLimit + 1;
	}

	public void startGame()
	{
		menuAudio.GetComponent<AudioSource> ().Stop ();
		gameAudio.GetComponent<AudioSource> ().Play ();
		//GameObject.FindGameObjectWithTag ("admanager").GetComponent<adManagerr> ().destroyBann ();

		SceneManager.LoadScene ("main");
	}

}
