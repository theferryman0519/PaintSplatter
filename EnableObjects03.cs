using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System.Data;
using System.IO;
using System.Net;

public class EnableObjects03 : MonoBehaviour {

// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image BackgroundImage;
	public Text LogoText;
	public Text WelcomeText;
	public Image PVCButton;
	public Image PVPButton;
	public Image DeckButton;
	public Image StoreButton;
	public Image SettingsButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableAllObjects();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingTexts();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE OBJECT FUNCTIONS ---------------
	public void EnableAllObjects() {
		BackgroundImage.enabled = true;
		LogoText.enabled = true;
		WelcomeText.enabled = true;
		PVCButton.enabled = true;
		PVPButton.enabled = true;
		DeckButton.enabled = true;
		StoreButton.enabled = true;
		SettingsButton.enabled = true;
	}

// --------------- DISABLE OBJECT FUNCTIONS ---------------
    public void DisableAllObjects() {
		BackgroundImage.enabled = false;
		LogoText.enabled = false;
		WelcomeText.enabled = false;
		PVCButton.enabled = false;
		PVPButton.enabled = false;
		DeckButton.enabled = false;
		StoreButton.enabled = false;
		SettingsButton.enabled = false;
	}

// --------------- UPDATING TEXTS FUNCTIONS ---------------
	public void UpdatingTexts() {
		WelcomeText.text = "Welcome, " + PlayerDatabase.PlayerFirstName;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}