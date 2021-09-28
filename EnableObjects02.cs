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

public class EnableObjects02 : MonoBehaviour {

// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image BackgroundImage;
	public Text LogoText;
	public Text VersionText;
	public Image LogInOnButton;
	public Image LogInOffButton;
	public Image SignUpOnButton;
	public Image SignUpOffButton;
	public Text UsernameText;
	public Image UsernameField;
	public Text UsernamePlace;
	public Text UsernameInput;
	public Text FirstNameText;
	public Image FirstNameField;
	public Text FirstNamePlace;
	public Text FirstNameInput;
	public Text FavArtistText;
	public Image FavArtistField;
	public Text FavArtistPlace;
	public Text FavArtistInput;
	public Image ContinueButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int LogInSignUpTracker;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		LogInSignUpTracker = 0;
		EnableMainObjects();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (LogInSignUpTracker == 0) {
			// Disable Objects
			DisableLogInOffButton();
			DisableSignUpOnButton();
			DisableFirstName();
			DisableFavArtist();

			// Enable Objects
			EnableLogInOnButton();
			EnableSignUpOffButton();
			EnableUsername();
		}

		else if (LogInSignUpTracker == 1) {
			// Disable Objects
			DisableLogInOnButton();
			DisableSignUpOffButton();
			
			// Enable Objects
			EnableLogInOffButton();
			EnableSignUpOnButton();
			EnableUsername();
			EnableFirstName();
			EnableFavArtist();
		}

		UpdatingTexts();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE OBJECT FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		LogoText.enabled = true;
		VersionText.enabled = true;
		ContinueButton.enabled = true;
	}

	public void EnableLogInOnButton() {
		LogInOnButton.enabled = true;
	}

	public void EnableLogInOffButton() {
		LogInOffButton.enabled = true;
	}

	public void EnableSignUpOnButton() {
		SignUpOnButton.enabled = true;
	}

	public void EnableSignUpOffButton() {
		SignUpOffButton.enabled = true;
	}

	public void EnableUsername() {
		UsernameText.enabled = true;
		UsernameField.enabled = true;
		UsernamePlace.enabled = true;
		UsernameInput.enabled = true;
	}

	public void EnableFirstName() {
		FirstNameText.enabled = true;
		FirstNameField.enabled = true;
		FirstNamePlace.enabled = true;
		FirstNameInput.enabled = true;
	}

	public void EnableFavArtist() {
		FavArtistText.enabled = true;
		FavArtistField.enabled = true;
		FavArtistPlace.enabled = true;
		FavArtistInput.enabled = true;
	}

// --------------- DISABLE OBJECT FUNCTIONS ---------------
    public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		LogoText.enabled = false;
		VersionText.enabled = false;
		ContinueButton.enabled = false;
	}

	public void DisableLogInOnButton() {
		LogInOnButton.enabled = false;
	}

	public void DisableLogInOffButton() {
		LogInOffButton.enabled = false;
	}

	public void DisableSignUpOnButton() {
		SignUpOnButton.enabled = false;
	}

	public void DisableSignUpOffButton() {
		SignUpOffButton.enabled = false;
	}

	public void DisableUsername() {
		UsernameText.enabled = false;
		UsernameField.enabled = false;
		UsernamePlace.enabled = false;
		UsernameInput.enabled = false;
	}

	public void DisableFirstName() {
		FirstNameText.enabled = false;
		FirstNameField.enabled = false;
		FirstNamePlace.enabled = false;
		FirstNameInput.enabled = false;
	}

	public void DisableFavArtist() {
		FavArtistText.enabled = false;
		FavArtistField.enabled = false;
		FavArtistPlace.enabled = false;
		FavArtistInput.enabled = false;
	}

// --------------- UPDATING TEXTS FUNCTIONS ---------------
	public void UpdatingTexts() {
		if (UsernameInput.text == "") {
			UsernamePlace.enabled = true;
		}

		else {
			UsernamePlace.enabled = false;
		}

		if ((FirstNameInput.text == "") && (LogInSignUpTracker == 1)) {
			FirstNamePlace.enabled = true;
		}

		else {
			FirstNamePlace.enabled = false;
		}

		if ((FavArtistInput.text == "") && (LogInSignUpTracker == 1)) {
			FavArtistPlace.enabled = true;
		}

		else {
			FavArtistPlace.enabled = false;
		}

		VersionText.text = "Version: 1.0";
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}