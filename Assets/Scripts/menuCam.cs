using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class menuCam : MonoBehaviour {
	//Manual colour models


	Color32 a,b,c,dd,ee,ff,gg,hh,ii,jj;


	public ParticleSystem ps;
	public Material groundd;
	public bool follow = true;
	public GameObject planee;
	Vector3 offset;
	float timmer;
	bool increase = true;
	int colorCode;
	//ParticleSystem.MainModule ma;
	// Use this for initialization
	void Start () 
	{
		//Camera.main.aspect = Screen.width/ Screen.height;
	//	ma = ps.main;
		offset = this.transform.position - planee.transform.position;

		colorCode = Random.Range (1, 11);
		a = new Color32 (255, 0, 173, 1);
		b = new Color32 (135, 52, 72, 1);
		c = new Color32 (178, 35, 0, 1);
		dd = new Color32 (40, 35, 10,1);
		ee = new Color32 (70, 10, 00,1);
		ff = new Color32 (50, 30, 40,1);
		gg = new Color32 (60, 39, 60, 1);
		hh = new Color32 (70, 40, 30, 1);
		ii = new Color32 (50, 20, 30, 1);
		jj = new Color32 (50, 35, 10, 1);
		Color32 tmp = new Color32 ( (byte)Random.Range (100, 115), (byte)Random.Range (80, 95), (byte)Random.Range (30, 50), 1);
		Camera.main.backgroundColor = tmp;
		groundd.SetColor ("_EmissionColor",tmp);
		groundd.color = tmp;

		//ma.startColor = new Color (tmp.r / 255, tmp.g / 255, tmp.b / 255, tmp.a / 255);
	}

	// Update is called once per frame
	void Update () 
	{
		if (follow) {   
			planee.transform.Translate (new Vector3 (0, 0, 2f * Time.deltaTime));
			//planee.transform.Translate (new Vector3 (0, 0, 2f * Time.deltaTime));
		}
		backgroundControl ();
	}
	void LateUpdate()
	{
		if (follow)
			transform.position = planee.transform.position + offset;
	}
	void backgroundControl()
	{
		if (colorCode == 1) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, dd,timmer*0.001f);
			groundd.SetColor ("_EmissionColor",Color.Lerp (Camera.main.backgroundColor, dd,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, dd,timmer*0.01f);

			//ma.startColor = Color.Lerp (Camera.main.backgroundColor, dd,timmer*0.01f);
		}
		else if (colorCode == 2) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, ff,timmer*0.001f);
			groundd.SetColor ("_EmissionColor",Color.Lerp (Camera.main.backgroundColor, ff,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, ff,timmer*0.01f);
			//ma.startColor = Color.Lerp (Camera.main.backgroundColor, ff,timmer*0.01f);

		}
		else if (colorCode == 3) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, ee,timmer*0.001f);
			groundd.SetColor ("_EmissionColor",Color.Lerp (Camera.main.backgroundColor, ee,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, ee,timmer*0.01f);
			//ma.startColor = Color.Lerp (Camera.main.backgroundColor, ee,timmer*0.01f);
		}
		else if (colorCode == 4) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, gg,timmer*0.001f);
			groundd.SetColor ("_EmissionColor",Color.Lerp (Camera.main.backgroundColor, gg,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, gg,timmer*0.01f);
			//ma.startColor = Color.Lerp (Camera.main.backgroundColor, gg,timmer*0.01f);

		}
		else if (colorCode == 5) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, jj,timmer*0.001f);
			groundd.SetColor ("_EmissionColor", Color.Lerp (Camera.main.backgroundColor, jj,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, jj,timmer*0.01f);
			//ma.startColor =Color.Lerp (Camera.main.backgroundColor, jj,timmer*0.01f);

		}
		else if (colorCode == 6) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, hh,timmer*0.001f);
			groundd.SetColor ("_EmissionColor",Color.Lerp (Camera.main.backgroundColor, hh,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, hh,timmer*0.01f);
			//ma.startColor = Color.Lerp (Camera.main.backgroundColor, hh,timmer*0.01f);

		}
		else if (colorCode == 7) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, ii,timmer*0.001f);
			groundd.SetColor ("_EmissionColor",Color.Lerp (Camera.main.backgroundColor, ii,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, ii,timmer*0.01f);
			//ma.startColor = Color.Lerp (Camera.main.backgroundColor, ii,timmer*0.01f);

		}
		else if (colorCode == 8) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, a,timmer*0.001f);
			groundd.SetColor ("_EmissionColor",Color.Lerp (Camera.main.backgroundColor,a,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, a,timmer*0.01f);
			//ma.startColor = Color.Lerp (Camera.main.backgroundColor, a,timmer*0.01f);

		}
		else if (colorCode == 9) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, b,timmer*0.001f);
			groundd.SetColor ("_EmissionColor",Color.Lerp (Camera.main.backgroundColor,b,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, b,timmer*0.01f);
			//ma.startColor = Color.Lerp (Camera.main.backgroundColor, b,timmer*0.01f);
		
		}
		else if (colorCode == 10) {
			Camera.main.backgroundColor = Color.Lerp (Camera.main.backgroundColor, c,timmer*0.001f);
			groundd.SetColor ("_EmissionColor",Color.Lerp (Camera.main.backgroundColor,c,timmer*0.1f));
			groundd.color = Color.Lerp (Camera.main.backgroundColor, c,timmer*0.01f);
			//ma.startColor = Color.Lerp (Camera.main.backgroundColor, c,timmer*0.01f);

		}
		//Debug.Log (timmer);
		/*if (Random.Range (1, 60) == 20) {
			colorCode = Random.Range (1, 8);
		}*/
		handleTimer ();
	}
	void handleTimer()
	{
		if (increase) {
			timmer = timmer + Time.deltaTime * 0.1f;
		} if (!increase){
			//timmer = (timmer - Time.deltaTime) * 0.001f;
			timmer = 0;
			colorCode = Random.Range (1, 11);
		}
		if ((int)timmer >= 1) {
			increase = false;
			Debug.Log ("increase");
		}
		if ((int)timmer <= 0) {
			increase = true;
		}

	}
}
