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

public class Buttons03 : MonoBehaviour {

// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button PVCButton;
	public Button PVPButton;
	public Button DeckButton;
	public Button StoreButton;
	public Button SettingsButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene07LoadRun;
	public SceneChange Scene10LoadRun;
	public SceneChange Scene13LoadRun;
	public SceneChange Scene14LoadRun;
	public SceneChange Scene15LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// PVCButton
		Button PVCButtonClick = PVCButton.GetComponent<Button>();
		PVCButtonClick.onClick.AddListener(PVCButtonClicking);

		// PVPButton
		Button PVPButtonClick = PVPButton.GetComponent<Button>();
		PVPButtonClick.onClick.AddListener(PVPButtonClicking);

		// DeckButton
		Button DeckButtonClick = DeckButton.GetComponent<Button>();
		DeckButtonClick.onClick.AddListener(DeckButtonClicking);

		// StoreButton
		Button StoreButtonClick = StoreButton.GetComponent<Button>();
		StoreButtonClick.onClick.AddListener(StoreButtonClicking);

		// SettingsButton
		Button SettingsButtonClick = SettingsButton.GetComponent<Button>();
		SettingsButtonClick.onClick.AddListener(SettingsButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void PVCButtonClicking() {
		Scene07LoadRun.Scene07Load();
	}

	public void PVPButtonClicking() {
		// Scene10LoadRun.Scene10Load();
	}

	public void DeckButtonClicking() {
		Scene13LoadRun.Scene13Load();
	}

	public void StoreButtonClicking() {
		Scene14LoadRun.Scene14Load();
	}

	public void SettingsButtonClicking() {
		Scene15LoadRun.Scene15Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}