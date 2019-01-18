using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camHandle : MonoBehaviour 
{



	public bool training1 = false;

	public bool gamePaused1 = false;

	//Manual colour models
	Color32 a,b,c,dd,ee,ff,gg,hh,ii,jj;


	public ParticleSystem ps;
	public Material groundd;
	public bool follow = true;
	public GameObject player,planee;
	float timmer;
	Vector3 offset;
	bool increase = true;
	int colorCode;
	//ParticleSystem.MainModule ma;
	// Use this for initialization
	void Start () 
	{
		//Camera.main.aspect = Screen.width/ Screen.height;
	//	 ma = ps.main;
		 
		offset = this.transform.position - player.transform.position;
		colorCode = Random.Range (1, 11);
		a = new Color32 (40, 0, 73, 1);
		b = new Color32 (75, 42, 0, 1);
		c = new Color32 (88, 55, 0, 1);
		dd = new Color32 (70, 90, 10,1);
		ee = new Color32 (80, 40, 00,1);
		ff = new Color32 (60, 70, 40,1);
		gg = new Color32 (50, 108, 60, 1);
		hh = new Color32 (70, 60, 30, 1);
		ii = new Color32 (65, 50, 30, 1);
		jj = new Color32 (50, 60, 10, 1);
		Color32 tmp = new Color32 ( (byte)Random.Range (40, 80), (byte)Random.Range (20,50), (byte)Random.Range (30, 60), 1);
		Camera.main.backgroundColor = tmp;
		groundd.SetColor ("_EmissionColor",tmp);
		groundd.color = tmp;
		//ma.startColor = new Color (tmp.r / 255, tmp.g / 255, tmp.b / 255, tmp.a / 255);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!training1 && !gamePaused1) {
			if (follow) {
				player.transform.Translate (new Vector3 (0, 0, 2f * Time.deltaTime));

				planee.transform.Translate (new Vector3 (0, 0, 2f * Time.deltaTime));
			}
			backgroundControl ();
		}
	}
	void LateUpdate()
	{
		if (follow)
		transform.position = player.transform.position + offset;
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