using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
public class adManagerr : MonoBehaviour {
	 BannerView bv;
	public InterstitialAd ia;
	bool first = false;
	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad (this);
//		if (!first)
		//MobileAds.Initialize ("ca");
		//Debug.Log (" first "+first);
		//first = true;
		//RequestBanner ();
		//RequestInterstatial ();


	}


	// Update is called once per frame
	void Update () 
	{

	}
	/*public void destroyBann()
	{
		this.bv.Destroy ();
		bv.Destroy ();
	}*/
	private void RequestBanner()
	{
		#if UNITY_ANDROID
		//string adUnitId = "ca";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Create a 320x50 banner at the top of the screen.
		//bv = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		//AdRequest request = new AdRequest.Builder().Build();
		//List<string> ls=request.TestDevices ;
		//Debug.Log ("device : " + ls.Count);
		// Load the banner with the request.

		//bv.LoadAd(request);
	}
	public void RequestInterstatial()
		{
		#if UNITY_ANDROID
		string adUnitId = "ca";
		#elif UNITY_IPHONE
		string adUnitId = "ca";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Create a 320x50 banner at the top of the screen.
		//ia = new InterstitialAd (adUnitId);
		// Create an empty ad request.
		//AdRequest request = new AdRequest.Builder().Build();

		// Load the banner with the request.
		//ia.LoadAd(request);
		}
		public void onPlayButtonPresed()
	{
		//bv.Hide ();
		//bv.Destroy ();
		//Debug.Log ("button pressed");
	}
}
