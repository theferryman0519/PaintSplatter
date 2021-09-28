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
	public Text CoinText;
	public Image PVCButton;
	public Image PVPButton;
	public Image DeckButton;
	public Image StoreButton;
	public Image SettingsButton;
	public Text CollectTextA;
	public Text CollectTextB;
	public Image CollectButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ShowDailyLogin;
	public static string TodaysDate;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableStartObjects();
		TodaysDate = System.DateTime.Now.ToString("MM/dd/yyyy");
		PlayerDatabase.PlayerDailyLogin = PlayerDatabase.PlayerDailyLogin.Replace("\\","");

		if (TodaysDate == PlayerDatabase.PlayerDailyLogin) {
			ShowDailyLogin = 0;
		}

		else if (TodaysDate != PlayerDatabase.PlayerDailyLogin) {
			ShowDailyLogin = 1;
		}
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingTexts();

		if (ShowDailyLogin == 0) {
			DisableLoginObjects();
			EnableMainObjects();
		}

		else if (ShowDailyLogin == 1) {
			DisableMainObjects();
			EnableLoginObjects();
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE OBJECT FUNCTIONS ---------------
	public void EnableStartObjects() {
		BackgroundImage.enabled = true;
		LogoText.enabled = true;
	}

	public void EnableMainObjects() {
		WelcomeText.enabled = true;
		CoinText.enabled = true;
		PVCButton.enabled = true;
		PVPButton.enabled = true;
		DeckButton.enabled = true;
		StoreButton.enabled = true;
		SettingsButton.enabled = true;
	}

	public void EnableLoginObjects() {
		CollectTextA.enabled = true;
		CollectTextB.enabled = true;
		CollectButton.enabled = true;
	}

// --------------- DISABLE OBJECT FUNCTIONS ---------------
	public void DisableStartObjects() {
		BackgroundImage.enabled = false;
		LogoText.enabled = false;
	}

    public void DisableMainObjects() {
		WelcomeText.enabled = false;
		CoinText.enabled = false;
		PVCButton.enabled = false;
		PVPButton.enabled = false;
		DeckButton.enabled = false;
		StoreButton.enabled = false;
		SettingsButton.enabled = false;
	}

	public void DisableLoginObjects() {
		CollectTextA.enabled = false;
		CollectTextB.enabled = false;
		CollectButton.enabled = false;
	}

// --------------- UPDATING TEXTS FUNCTIONS ---------------
	public void UpdatingTexts() {
		WelcomeText.text = "Welcome, " + PlayerDatabase.PlayerFirstName;

		if (PlayerDatabase.PlayerCoinAmount == "1") {
			CoinText.text = "You have " + PlayerDatabase.PlayerCoinAmount + " Coin";
		}

		else {
			CoinText.text = "You have " + PlayerDatabase.PlayerCoinAmount + " Coins";
		}

		if (PlayerDatabase.PlayerCollectLevelReward == "1") {
			CollectTextA.text = "Congratulations for logging in 2 days!";
			CollectTextB.text = "Your reward for today is:" + "\n" + "2 Coins";
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "2") {
			CollectTextA.text = "Congratulations for logging in 3 days!";
			CollectTextB.text = "Your reward for today is:" + "\n" + "5 Coins";
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "3") {
			CollectTextA.text = "Congratulations for logging in 4 days!";
			CollectTextB.text = "Your reward for today is:" + "\n" + "Paint Card";
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "4") {
			CollectTextA.text = "Congratulations for logging in 5 days!";
			CollectTextB.text = "Your reward for today is:" + "\n" + "10 Coins";
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "5") {
			CollectTextA.text = "Congratulations for logging in 6 days!";
			CollectTextB.text = "Your reward for today is:" + "\n" + "Artist Card";
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "6") {
			CollectTextA.text = "Congratulations for logging in 7 days!";
			CollectTextB.text = "Your streak will reset after today" + "\n\n" + "Your reward for today is:" + "\n" + "20 Coins";
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}