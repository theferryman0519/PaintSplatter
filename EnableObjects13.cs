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

public class EnableObjects13 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image ArtworksButtonOn;
	public Image ArtistsButtonOn;
	public Image PatronsButtonOn;
	public Image PaintsButtonOn;
	public Image ArtworksButtonOff;
	public Image ArtistsButtonOff;
	public Image PatronsButtonOff;
	public Image PaintsButtonOff;
	public Image BackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ShowCardTypeInt;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMainObjects();
		ShowCardTypeInt = 1;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		ShowCardTypes();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBJECT FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
		BackButton.enabled = true;
	}

	public void EnableArtworksButtonOn() {
		ArtworksButtonOn.enabled = true;
	}

	public void EnableArtistsButtonOn() {
		ArtistsButtonOn.enabled = true;
	}

	public void EnablePatronsButtonOn() {
		PatronsButtonOn.enabled = true;
	}

	public void EnablePaintsButtonOn() {
		PaintsButtonOn.enabled = true;
	}

	public void EnableArtworksButtonOff() {
		ArtworksButtonOff.enabled = true;
	}

	public void EnableArtistsButtonOff() {
		ArtistsButtonOff.enabled = true;
	}

	public void EnablePatronsButtonOff() {
		PatronsButtonOff.enabled = true;
	}

	public void EnablePaintsButtonOff() {
		PaintsButtonOff.enabled = true;
	}

// --------------- DISABLING OBJECT FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ActionText.enabled = false;
		BackButton.enabled = false;
	}

	public void DisableArtworksButtonOn() {
		ArtworksButtonOn.enabled = false;
	}

	public void DisableArtistsButtonOn() {
		ArtistsButtonOn.enabled = false;
	}

	public void DisablePatronsButtonOn() {
		PatronsButtonOn.enabled = false;
	}

	public void DisablePaintsButtonOn() {
		PaintsButtonOn.enabled = false;
	}

	public void DisableArtworksButtonOff() {
		ArtworksButtonOff.enabled = false;
	}

	public void DisableArtistsButtonOff() {
		ArtistsButtonOff.enabled = false;
	}

	public void DisablePatronsButtonOff() {
		PatronsButtonOff.enabled = false;
	}

	public void DisablePaintsButtonOff() {
		PaintsButtonOff.enabled = false;
	}

	public void DisableAllCards() {
		DisableArtworksButtonOn();
		DisableArtistsButtonOn();
		DisablePatronsButtonOn();
		DisablePaintsButtonOn();
		DisableArtworksButtonOff();
		DisableArtistsButtonOff();
		DisablePatronsButtonOff();
		DisablePaintsButtonOff();
	}

// --------------- SHOW CARD TYPE FUNCTIONS ---------------
	public void ShowCardTypes() {
		if (ShowCardTypeInt == 1) {
			// Disable All Card Types
			DisableAllCards();

			// Enable Select Card Type - On
			EnableArtworksButtonOn();

			// Enable Select Card Type - Off
			EnableArtistsButtonOff();
			EnablePatronsButtonOff();
			EnablePaintsButtonOff();
		}

		else if (ShowCardTypeInt == 2) {
			// Disable All Card Types
			DisableAllCards();

			// Enable Select Card Type - On
			EnableArtistsButtonOn();

			// Enable Select Card Type - Off
			EnableArtworksButtonOff();
			EnablePatronsButtonOff();
			EnablePaintsButtonOff();
		}

		else if (ShowCardTypeInt == 3) {
			// Disable All Card Types
			DisableAllCards();

			// Enable Select Card Type - On
			EnablePatronsButtonOn();

			// Enable Select Card Type - Off
			EnableArtworksButtonOff();
			EnableArtistsButtonOff();
			EnablePaintsButtonOff();
		}

		else if (ShowCardTypeInt == 4) {
			// Disable All Card Types
			DisableAllCards();

			// Enable Select Card Type - On
			EnablePaintsButtonOn();

			// Enable Select Card Type - Off
			EnableArtworksButtonOff();
			EnableArtistsButtonOff();
			EnablePatronsButtonOff();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}