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

public class Buttons13 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button ArtworksButtonOn;
	public Button ArtistsButtonOn;
	public Button PatronsButtonOn;
	public Button PaintsButtonOn;
	public Button ArtworksButtonOff;
	public Button ArtistsButtonOff;
	public Button PatronsButtonOff;
	public Button PaintsButtonOff;
	public Button BackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene03LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// ArtworksButtonOn
		Button ArtworksButtonOnClick = ArtworksButtonOn.GetComponent<Button>();
		ArtworksButtonOnClick.onClick.AddListener(ArtworksButtonOnClicking);

		// ArtistsButtonOn
		Button ArtistsButtonOnClick = ArtistsButtonOn.GetComponent<Button>();
		ArtistsButtonOnClick.onClick.AddListener(ArtistsButtonOnClicking);

		// PatronsButtonOn
		Button PatronsButtonOnClick = PatronsButtonOn.GetComponent<Button>();
		PatronsButtonOnClick.onClick.AddListener(PatronsButtonOnClicking);

		// PaintsButtonOn
		Button PaintsButtonOnClick = PaintsButtonOn.GetComponent<Button>();
		PaintsButtonOnClick.onClick.AddListener(PaintsButtonOnClicking);

		// ArtworksButtonOff
		Button ArtworksButtonOffClick = ArtworksButtonOff.GetComponent<Button>();
		ArtworksButtonOffClick.onClick.AddListener(ArtworksButtonOffClicking);

		// ArtistsButtonOff
		Button ArtistsButtonOffClick = ArtistsButtonOff.GetComponent<Button>();
		ArtistsButtonOffClick.onClick.AddListener(ArtistsButtonOffClicking);

		// PatronsButtonOff
		Button PatronsButtonOffClick = PatronsButtonOff.GetComponent<Button>();
		PatronsButtonOffClick.onClick.AddListener(PatronsButtonOffClicking);

		// PaintsButtonOff
		Button PaintsButtonOffClick = PaintsButtonOff.GetComponent<Button>();
		PaintsButtonOffClick.onClick.AddListener(PaintsButtonOffClicking);

		// BackButton
		Button BackButtonClick = BackButton.GetComponent<Button>();
		BackButtonClick.onClick.AddListener(BackButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void ArtworksButtonOnClicking() {
		EnableObjects13.ShowCardTypeInt = 1;
	}

	public void ArtistsButtonOnClicking() {
		EnableObjects13.ShowCardTypeInt = 2;
	}

	public void PatronsButtonOnClicking() {
		EnableObjects13.ShowCardTypeInt = 3;
	}

	public void PaintsButtonOnClicking() {
		EnableObjects13.ShowCardTypeInt = 4;
	}

	public void ArtworksButtonOffClicking() {
		EnableObjects13.ShowCardTypeInt = 1;
	}

	public void ArtistsButtonOffClicking() {
		EnableObjects13.ShowCardTypeInt = 2;
	}

	public void PatronsButtonOffClicking() {
		EnableObjects13.ShowCardTypeInt = 3;
	}

	public void PaintsButtonOffClicking() {
		EnableObjects13.ShowCardTypeInt = 4;
	}

	public void BackButtonClicking() {
		Scene03LoadRun.Scene03Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}