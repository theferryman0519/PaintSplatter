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

public class EnableObjects16 : MonoBehaviour {

// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image BackgroundImage;
	public Text ErrorText;
	public Text MainText;
	public Image BackButton;
	
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
		ErrorText.enabled = true;
		MainText.enabled = true;
		BackButton.enabled = true;
	}

// --------------- DISABLE OBJECT FUNCTIONS ---------------
    public void DisableAllObjects() {
		BackgroundImage.enabled = false;
		ErrorText.enabled = false;
		MainText.enabled = false;
		BackButton.enabled = false;
	}

// --------------- UPDATING TEXTS FUNCTIONS ---------------
	public void UpdatingTexts() {
		if (Buttons02.LogInErrorTracker == 1) {
			MainText.text = "Unfortunately, the Username you have entered is not in our database. Please go back and either try entering your Username again or Sign Up to create a new player.";
		}

		else if (Buttons02.LogInErrorTracker == 2) {
			MainText.text = "Unfortunately, the Username you have entered is already taken. Please go baxk and enter a new Username in order to Sign Up as a new player.";
		}

		else if (Buttons02.LogInErrorTracker == 3) {
			MainText.text = "Unfortunately, you are unable to either Log In or Sign Up at this moment. Please go back and try again in a few moments.";
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}