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
	public Button DeckButton;
	public Button StoreButton;
	public Button SettingsButton;
	public Button CollectButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int RandomPaintCollectInt;
	public static int RandomArtistCollectInt;
	
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

		// DeckButton
		Button DeckButtonClick = DeckButton.GetComponent<Button>();
		DeckButtonClick.onClick.AddListener(DeckButtonClicking);

		// StoreButton
		Button StoreButtonClick = StoreButton.GetComponent<Button>();
		StoreButtonClick.onClick.AddListener(StoreButtonClicking);

		// SettingsButton
		Button SettingsButtonClick = SettingsButton.GetComponent<Button>();
		SettingsButtonClick.onClick.AddListener(SettingsButtonClicking);

		// CollectButton
		Button CollectButtonClick = CollectButton.GetComponent<Button>();
		CollectButtonClick.onClick.AddListener(CollectButtonClicking);
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

	public void DeckButtonClicking() {
		Scene13LoadRun.Scene13Load();
	}

	public void StoreButtonClicking() {
		Scene14LoadRun.Scene14Load();
	}

	public void SettingsButtonClicking() {
		Scene15LoadRun.Scene15Load();
	}

	public void CollectButtonClicking() {
		if (PlayerDatabase.PlayerCollectLevelReward == "1") {
			PlayerDatabase.PlayerCoinAmount = (System.Int32.Parse(PlayerDatabase.PlayerCoinAmount) + 2).ToString();
			EnableObjects03.ShowDailyLogin = 0;
			PlayerDatabase.PlayerCollectLevelReward = "2";
			StartCoroutine(SettingPlayerData());
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "2") {
			PlayerDatabase.PlayerCoinAmount = (System.Int32.Parse(PlayerDatabase.PlayerCoinAmount) + 5).ToString();
			EnableObjects03.ShowDailyLogin = 0;
			PlayerDatabase.PlayerCollectLevelReward = "3";
			StartCoroutine(SettingPlayerData());
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "3") {
			RandomizePaintCollect();
			EnableObjects03.ShowDailyLogin = 0;
			PlayerDatabase.PlayerCollectLevelReward = "4";
			StartCoroutine(SettingPlayerData());
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "4") {
			PlayerDatabase.PlayerCoinAmount = (System.Int32.Parse(PlayerDatabase.PlayerCoinAmount) + 10).ToString();
			EnableObjects03.ShowDailyLogin = 0;
			PlayerDatabase.PlayerCollectLevelReward = "5";
			StartCoroutine(SettingPlayerData());
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "5") {
			RandomizeArtistCollect();
			EnableObjects03.ShowDailyLogin = 0;
			PlayerDatabase.PlayerCollectLevelReward = "6";
			StartCoroutine(SettingPlayerData());
		}

		else if (PlayerDatabase.PlayerCollectLevelReward == "6") {
			PlayerDatabase.PlayerCoinAmount = (System.Int32.Parse(PlayerDatabase.PlayerCoinAmount) + 20).ToString();
			EnableObjects03.ShowDailyLogin = 0;
			PlayerDatabase.PlayerCollectLevelReward = "1";
			StartCoroutine(SettingPlayerData());
		}
	}

	public void RandomizePaintCollect() {
		RandomPaintCollectInt = Random.Range(1,155);

		if (RandomPaintCollectInt == 1) {
			PlayerDatabase.CollectedPaint001 = (System.Int32.Parse(PlayerDatabase.CollectedPaint001) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 2) {
			PlayerDatabase.CollectedPaint001 = (System.Int32.Parse(PlayerDatabase.CollectedPaint001) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 3) {
			PlayerDatabase.CollectedPaint001 = (System.Int32.Parse(PlayerDatabase.CollectedPaint001) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 4) {
			PlayerDatabase.CollectedPaint002 = (System.Int32.Parse(PlayerDatabase.CollectedPaint002) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 5) {
			PlayerDatabase.CollectedPaint002 = (System.Int32.Parse(PlayerDatabase.CollectedPaint002) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 6) {
			PlayerDatabase.CollectedPaint002 = (System.Int32.Parse(PlayerDatabase.CollectedPaint002) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 7) {
			PlayerDatabase.CollectedPaint003 = (System.Int32.Parse(PlayerDatabase.CollectedPaint003) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 8) {
			PlayerDatabase.CollectedPaint003 = (System.Int32.Parse(PlayerDatabase.CollectedPaint003) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 9) {
			PlayerDatabase.CollectedPaint004 = (System.Int32.Parse(PlayerDatabase.CollectedPaint004) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 10) {
			PlayerDatabase.CollectedPaint004 = (System.Int32.Parse(PlayerDatabase.CollectedPaint004) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 11) {
			PlayerDatabase.CollectedPaint004 = (System.Int32.Parse(PlayerDatabase.CollectedPaint004) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 12) {
			PlayerDatabase.CollectedPaint005 = (System.Int32.Parse(PlayerDatabase.CollectedPaint005) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 13) {
			PlayerDatabase.CollectedPaint005 = (System.Int32.Parse(PlayerDatabase.CollectedPaint005) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 14) {
			PlayerDatabase.CollectedPaint006 = (System.Int32.Parse(PlayerDatabase.CollectedPaint006) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 15) {
			PlayerDatabase.CollectedPaint006 = (System.Int32.Parse(PlayerDatabase.CollectedPaint006) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 16) {
			PlayerDatabase.CollectedPaint007 = (System.Int32.Parse(PlayerDatabase.CollectedPaint007) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 17) {
			PlayerDatabase.CollectedPaint007 = (System.Int32.Parse(PlayerDatabase.CollectedPaint007) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 18) {
			PlayerDatabase.CollectedPaint007 = (System.Int32.Parse(PlayerDatabase.CollectedPaint007) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 19) {
			PlayerDatabase.CollectedPaint008 = (System.Int32.Parse(PlayerDatabase.CollectedPaint008) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 20) {
			PlayerDatabase.CollectedPaint008 = (System.Int32.Parse(PlayerDatabase.CollectedPaint008) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 21) {
			PlayerDatabase.CollectedPaint009 = (System.Int32.Parse(PlayerDatabase.CollectedPaint009) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 22) {
			PlayerDatabase.CollectedPaint009 = (System.Int32.Parse(PlayerDatabase.CollectedPaint009) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 23) {
			PlayerDatabase.CollectedPaint009 = (System.Int32.Parse(PlayerDatabase.CollectedPaint009) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 24) {
			PlayerDatabase.CollectedPaint010 = (System.Int32.Parse(PlayerDatabase.CollectedPaint010) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 25) {
			PlayerDatabase.CollectedPaint010 = (System.Int32.Parse(PlayerDatabase.CollectedPaint010) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 26) {
			PlayerDatabase.CollectedPaint011 = (System.Int32.Parse(PlayerDatabase.CollectedPaint011) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 27) {
			PlayerDatabase.CollectedPaint011 = (System.Int32.Parse(PlayerDatabase.CollectedPaint011) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 28) {
			PlayerDatabase.CollectedPaint011 = (System.Int32.Parse(PlayerDatabase.CollectedPaint011) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 29) {
			PlayerDatabase.CollectedPaint012 = (System.Int32.Parse(PlayerDatabase.CollectedPaint012) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 30) {
			PlayerDatabase.CollectedPaint012 = (System.Int32.Parse(PlayerDatabase.CollectedPaint012) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 31) {
			PlayerDatabase.CollectedPaint012 = (System.Int32.Parse(PlayerDatabase.CollectedPaint012) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 32) {
			PlayerDatabase.CollectedPaint013 = (System.Int32.Parse(PlayerDatabase.CollectedPaint013) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 33) {
			PlayerDatabase.CollectedPaint013 = (System.Int32.Parse(PlayerDatabase.CollectedPaint013) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 34) {
			PlayerDatabase.CollectedPaint013 = (System.Int32.Parse(PlayerDatabase.CollectedPaint013) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 35) {
			PlayerDatabase.CollectedPaint014 = (System.Int32.Parse(PlayerDatabase.CollectedPaint014) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 36) {
			PlayerDatabase.CollectedPaint014 = (System.Int32.Parse(PlayerDatabase.CollectedPaint014) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 37) {
			PlayerDatabase.CollectedPaint014 = (System.Int32.Parse(PlayerDatabase.CollectedPaint014) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 38) {
			PlayerDatabase.CollectedPaint015 = (System.Int32.Parse(PlayerDatabase.CollectedPaint015) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 39) {
			PlayerDatabase.CollectedPaint015 = (System.Int32.Parse(PlayerDatabase.CollectedPaint015) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 40) {
			PlayerDatabase.CollectedPaint016 = (System.Int32.Parse(PlayerDatabase.CollectedPaint016) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 41) {
			PlayerDatabase.CollectedPaint016 = (System.Int32.Parse(PlayerDatabase.CollectedPaint016) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 42) {
			PlayerDatabase.CollectedPaint017 = (System.Int32.Parse(PlayerDatabase.CollectedPaint017) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 43) {
			PlayerDatabase.CollectedPaint017 = (System.Int32.Parse(PlayerDatabase.CollectedPaint017) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 44) {
			PlayerDatabase.CollectedPaint017 = (System.Int32.Parse(PlayerDatabase.CollectedPaint017) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 45) {
			PlayerDatabase.CollectedPaint018 = (System.Int32.Parse(PlayerDatabase.CollectedPaint018) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 46) {
			PlayerDatabase.CollectedPaint018 = (System.Int32.Parse(PlayerDatabase.CollectedPaint018) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 47) {
			PlayerDatabase.CollectedPaint018 = (System.Int32.Parse(PlayerDatabase.CollectedPaint018) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 48) {
			PlayerDatabase.CollectedPaint019 = (System.Int32.Parse(PlayerDatabase.CollectedPaint019) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 49) {
			PlayerDatabase.CollectedPaint019 = (System.Int32.Parse(PlayerDatabase.CollectedPaint019) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 50) {
			PlayerDatabase.CollectedPaint020 = (System.Int32.Parse(PlayerDatabase.CollectedPaint020) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 51) {
			PlayerDatabase.CollectedPaint020 = (System.Int32.Parse(PlayerDatabase.CollectedPaint020) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 52) {
			PlayerDatabase.CollectedPaint020 = (System.Int32.Parse(PlayerDatabase.CollectedPaint020) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 53) {
			PlayerDatabase.CollectedPaint021 = (System.Int32.Parse(PlayerDatabase.CollectedPaint021) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 54) {
			PlayerDatabase.CollectedPaint021 = (System.Int32.Parse(PlayerDatabase.CollectedPaint021) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 55) {
			PlayerDatabase.CollectedPaint021 = (System.Int32.Parse(PlayerDatabase.CollectedPaint021) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 56) {
			PlayerDatabase.CollectedPaint022 = (System.Int32.Parse(PlayerDatabase.CollectedPaint022) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 57) {
			PlayerDatabase.CollectedPaint022 = (System.Int32.Parse(PlayerDatabase.CollectedPaint022) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 58) {
			PlayerDatabase.CollectedPaint022 = (System.Int32.Parse(PlayerDatabase.CollectedPaint022) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 59) {
			PlayerDatabase.CollectedPaint023 = (System.Int32.Parse(PlayerDatabase.CollectedPaint023) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 60) {
			PlayerDatabase.CollectedPaint023 = (System.Int32.Parse(PlayerDatabase.CollectedPaint023) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 61) {
			PlayerDatabase.CollectedPaint024 = (System.Int32.Parse(PlayerDatabase.CollectedPaint024) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 62) {
			PlayerDatabase.CollectedPaint024 = (System.Int32.Parse(PlayerDatabase.CollectedPaint024) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 63) {
			PlayerDatabase.CollectedPaint025 = (System.Int32.Parse(PlayerDatabase.CollectedPaint025) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 64) {
			PlayerDatabase.CollectedPaint025 = (System.Int32.Parse(PlayerDatabase.CollectedPaint025) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 65) {
			PlayerDatabase.CollectedPaint025 = (System.Int32.Parse(PlayerDatabase.CollectedPaint025) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 66) {
			PlayerDatabase.CollectedPaint026 = (System.Int32.Parse(PlayerDatabase.CollectedPaint026) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 67) {
			PlayerDatabase.CollectedPaint026 = (System.Int32.Parse(PlayerDatabase.CollectedPaint026) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 68) {
			PlayerDatabase.CollectedPaint027 = (System.Int32.Parse(PlayerDatabase.CollectedPaint027) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 69) {
			PlayerDatabase.CollectedPaint027 = (System.Int32.Parse(PlayerDatabase.CollectedPaint027) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 70) {
			PlayerDatabase.CollectedPaint028 = (System.Int32.Parse(PlayerDatabase.CollectedPaint028) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 71) {
			PlayerDatabase.CollectedPaint028 = (System.Int32.Parse(PlayerDatabase.CollectedPaint028) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 72) {
			PlayerDatabase.CollectedPaint028 = (System.Int32.Parse(PlayerDatabase.CollectedPaint028) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 73) {
			PlayerDatabase.CollectedPaint029 = (System.Int32.Parse(PlayerDatabase.CollectedPaint029) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 74) {
			PlayerDatabase.CollectedPaint029 = (System.Int32.Parse(PlayerDatabase.CollectedPaint029) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 75) {
			PlayerDatabase.CollectedPaint030 = (System.Int32.Parse(PlayerDatabase.CollectedPaint030) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 76) {
			PlayerDatabase.CollectedPaint030 = (System.Int32.Parse(PlayerDatabase.CollectedPaint030) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 77) {
			PlayerDatabase.CollectedPaint030 = (System.Int32.Parse(PlayerDatabase.CollectedPaint030) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 78) {
			PlayerDatabase.CollectedPaint031 = (System.Int32.Parse(PlayerDatabase.CollectedPaint031) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 79) {
			PlayerDatabase.CollectedPaint031 = (System.Int32.Parse(PlayerDatabase.CollectedPaint031) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 80) {
			PlayerDatabase.CollectedPaint032 = (System.Int32.Parse(PlayerDatabase.CollectedPaint032) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 81) {
			PlayerDatabase.CollectedPaint032 = (System.Int32.Parse(PlayerDatabase.CollectedPaint032) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 82) {
			PlayerDatabase.CollectedPaint033 = (System.Int32.Parse(PlayerDatabase.CollectedPaint033) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 83) {
			PlayerDatabase.CollectedPaint033 = (System.Int32.Parse(PlayerDatabase.CollectedPaint033) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 84) {
			PlayerDatabase.CollectedPaint034 = (System.Int32.Parse(PlayerDatabase.CollectedPaint034) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 85) {
			PlayerDatabase.CollectedPaint034 = (System.Int32.Parse(PlayerDatabase.CollectedPaint034) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 86) {
			PlayerDatabase.CollectedPaint034 = (System.Int32.Parse(PlayerDatabase.CollectedPaint034) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 87) {
			PlayerDatabase.CollectedPaint035 = (System.Int32.Parse(PlayerDatabase.CollectedPaint035) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 88) {
			PlayerDatabase.CollectedPaint035 = (System.Int32.Parse(PlayerDatabase.CollectedPaint035) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 89) {
			PlayerDatabase.CollectedPaint036 = (System.Int32.Parse(PlayerDatabase.CollectedPaint036) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 90) {
			PlayerDatabase.CollectedPaint036 = (System.Int32.Parse(PlayerDatabase.CollectedPaint036) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 91) {
			PlayerDatabase.CollectedPaint036 = (System.Int32.Parse(PlayerDatabase.CollectedPaint036) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 92) {
			PlayerDatabase.CollectedPaint037 = (System.Int32.Parse(PlayerDatabase.CollectedPaint037) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 93) {
			PlayerDatabase.CollectedPaint037 = (System.Int32.Parse(PlayerDatabase.CollectedPaint037) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 94) {
			PlayerDatabase.CollectedPaint037 = (System.Int32.Parse(PlayerDatabase.CollectedPaint037) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 95) {
			PlayerDatabase.CollectedPaint038 = (System.Int32.Parse(PlayerDatabase.CollectedPaint038) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 96) {
			PlayerDatabase.CollectedPaint038 = (System.Int32.Parse(PlayerDatabase.CollectedPaint038) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 97) {
			PlayerDatabase.CollectedPaint039 = (System.Int32.Parse(PlayerDatabase.CollectedPaint039) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 98) {
			PlayerDatabase.CollectedPaint039 = (System.Int32.Parse(PlayerDatabase.CollectedPaint039) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 99) {
			PlayerDatabase.CollectedPaint040 = (System.Int32.Parse(PlayerDatabase.CollectedPaint040) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 100) {
			PlayerDatabase.CollectedPaint040 = (System.Int32.Parse(PlayerDatabase.CollectedPaint040) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 101) {
			PlayerDatabase.CollectedPaint040 = (System.Int32.Parse(PlayerDatabase.CollectedPaint040) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 102) {
			PlayerDatabase.CollectedPaint041 = (System.Int32.Parse(PlayerDatabase.CollectedPaint041) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 103) {
			PlayerDatabase.CollectedPaint041 = (System.Int32.Parse(PlayerDatabase.CollectedPaint041) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 104) {
			PlayerDatabase.CollectedPaint041 = (System.Int32.Parse(PlayerDatabase.CollectedPaint041) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 105) {
			PlayerDatabase.CollectedPaint042 = (System.Int32.Parse(PlayerDatabase.CollectedPaint042) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 106) {
			PlayerDatabase.CollectedPaint042 = (System.Int32.Parse(PlayerDatabase.CollectedPaint042) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 107) {
			PlayerDatabase.CollectedPaint043 = (System.Int32.Parse(PlayerDatabase.CollectedPaint043) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 108) {
			PlayerDatabase.CollectedPaint043 = (System.Int32.Parse(PlayerDatabase.CollectedPaint043) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 109) {
			PlayerDatabase.CollectedPaint044 = (System.Int32.Parse(PlayerDatabase.CollectedPaint044) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 110) {
			PlayerDatabase.CollectedPaint044 = (System.Int32.Parse(PlayerDatabase.CollectedPaint044) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 111) {
			PlayerDatabase.CollectedPaint045 = (System.Int32.Parse(PlayerDatabase.CollectedPaint045) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 112) {
			PlayerDatabase.CollectedPaint045 = (System.Int32.Parse(PlayerDatabase.CollectedPaint045) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 113) {
			PlayerDatabase.CollectedPaint045 = (System.Int32.Parse(PlayerDatabase.CollectedPaint045) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 114) {
			PlayerDatabase.CollectedPaint046 = (System.Int32.Parse(PlayerDatabase.CollectedPaint046) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 115) {
			PlayerDatabase.CollectedPaint046 = (System.Int32.Parse(PlayerDatabase.CollectedPaint046) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 116) {
			PlayerDatabase.CollectedPaint047 = (System.Int32.Parse(PlayerDatabase.CollectedPaint047) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 117) {
			PlayerDatabase.CollectedPaint047 = (System.Int32.Parse(PlayerDatabase.CollectedPaint047) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 118) {
			PlayerDatabase.CollectedPaint047 = (System.Int32.Parse(PlayerDatabase.CollectedPaint047) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 119) {
			PlayerDatabase.CollectedPaint048 = (System.Int32.Parse(PlayerDatabase.CollectedPaint048) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 120) {
			PlayerDatabase.CollectedPaint048 = (System.Int32.Parse(PlayerDatabase.CollectedPaint048) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 121) {
			PlayerDatabase.CollectedPaint049 = (System.Int32.Parse(PlayerDatabase.CollectedPaint049) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 122) {
			PlayerDatabase.CollectedPaint049 = (System.Int32.Parse(PlayerDatabase.CollectedPaint049) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 123) {
			PlayerDatabase.CollectedPaint049 = (System.Int32.Parse(PlayerDatabase.CollectedPaint049) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 124) {
			PlayerDatabase.CollectedPaint050 = (System.Int32.Parse(PlayerDatabase.CollectedPaint050) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 125) {
			PlayerDatabase.CollectedPaint050 = (System.Int32.Parse(PlayerDatabase.CollectedPaint050) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 126) {
			PlayerDatabase.CollectedPaint050 = (System.Int32.Parse(PlayerDatabase.CollectedPaint050) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 127) {
			PlayerDatabase.CollectedPaint051 = (System.Int32.Parse(PlayerDatabase.CollectedPaint051) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 128) {
			PlayerDatabase.CollectedPaint051 = (System.Int32.Parse(PlayerDatabase.CollectedPaint051) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 129) {
			PlayerDatabase.CollectedPaint051 = (System.Int32.Parse(PlayerDatabase.CollectedPaint051) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 130) {
			PlayerDatabase.CollectedPaint052 = (System.Int32.Parse(PlayerDatabase.CollectedPaint052) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 131) {
			PlayerDatabase.CollectedPaint052 = (System.Int32.Parse(PlayerDatabase.CollectedPaint052) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 132) {
			PlayerDatabase.CollectedPaint053 = (System.Int32.Parse(PlayerDatabase.CollectedPaint053) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 133) {
			PlayerDatabase.CollectedPaint053 = (System.Int32.Parse(PlayerDatabase.CollectedPaint053) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 134) {
			PlayerDatabase.CollectedPaint053 = (System.Int32.Parse(PlayerDatabase.CollectedPaint053) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 135) {
			PlayerDatabase.CollectedPaint054 = (System.Int32.Parse(PlayerDatabase.CollectedPaint054) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 136) {
			PlayerDatabase.CollectedPaint054 = (System.Int32.Parse(PlayerDatabase.CollectedPaint054) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 137) {
			PlayerDatabase.CollectedPaint054 = (System.Int32.Parse(PlayerDatabase.CollectedPaint054) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 138) {
			PlayerDatabase.CollectedPaint055 = (System.Int32.Parse(PlayerDatabase.CollectedPaint055) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 139) {
			PlayerDatabase.CollectedPaint055 = (System.Int32.Parse(PlayerDatabase.CollectedPaint055) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 140) {
			PlayerDatabase.CollectedPaint055 = (System.Int32.Parse(PlayerDatabase.CollectedPaint055) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 141) {
			PlayerDatabase.CollectedPaint056 = (System.Int32.Parse(PlayerDatabase.CollectedPaint056) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 142) {
			PlayerDatabase.CollectedPaint056 = (System.Int32.Parse(PlayerDatabase.CollectedPaint056) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 143) {
			PlayerDatabase.CollectedPaint057 = (System.Int32.Parse(PlayerDatabase.CollectedPaint057) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 144) {
			PlayerDatabase.CollectedPaint057 = (System.Int32.Parse(PlayerDatabase.CollectedPaint057) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 145) {
			PlayerDatabase.CollectedPaint058 = (System.Int32.Parse(PlayerDatabase.CollectedPaint058) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 146) {
			PlayerDatabase.CollectedPaint058 = (System.Int32.Parse(PlayerDatabase.CollectedPaint058) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 147) {
			PlayerDatabase.CollectedPaint059 = (System.Int32.Parse(PlayerDatabase.CollectedPaint059) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 148) {
			PlayerDatabase.CollectedPaint059 = (System.Int32.Parse(PlayerDatabase.CollectedPaint059) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 149) {
			PlayerDatabase.CollectedPaint060 = (System.Int32.Parse(PlayerDatabase.CollectedPaint060) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 150) {
			PlayerDatabase.CollectedPaint060 = (System.Int32.Parse(PlayerDatabase.CollectedPaint060) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 151) {
			PlayerDatabase.CollectedPaint061 = (System.Int32.Parse(PlayerDatabase.CollectedPaint061) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 152) {
			PlayerDatabase.CollectedPaint061 = (System.Int32.Parse(PlayerDatabase.CollectedPaint061) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 153) {
			PlayerDatabase.CollectedPaint062 = (System.Int32.Parse(PlayerDatabase.CollectedPaint062) + 1).ToString();
		}

		else if (RandomPaintCollectInt == 154) {
			PlayerDatabase.CollectedPaint062 = (System.Int32.Parse(PlayerDatabase.CollectedPaint062) + 1).ToString();
		}
	}

	public void RandomizeArtistCollect() {
		RandomArtistCollectInt = Random.Range(1,188);

		if (RandomArtistCollectInt == 1) {
			PlayerDatabase.CollectedArtist001 = (System.Int32.Parse(PlayerDatabase.CollectedArtist001) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 2) {
			PlayerDatabase.CollectedArtist001 = (System.Int32.Parse(PlayerDatabase.CollectedArtist001) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 3) {
			PlayerDatabase.CollectedArtist001 = (System.Int32.Parse(PlayerDatabase.CollectedArtist001) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 4) {
			PlayerDatabase.CollectedArtist001 = (System.Int32.Parse(PlayerDatabase.CollectedArtist001) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 5) {
			PlayerDatabase.CollectedArtist002 = (System.Int32.Parse(PlayerDatabase.CollectedArtist002) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 6) {
			PlayerDatabase.CollectedArtist002 = (System.Int32.Parse(PlayerDatabase.CollectedArtist002) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 7) {
			PlayerDatabase.CollectedArtist002 = (System.Int32.Parse(PlayerDatabase.CollectedArtist002) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 8) {
			PlayerDatabase.CollectedArtist003 = (System.Int32.Parse(PlayerDatabase.CollectedArtist003) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 9) {
			PlayerDatabase.CollectedArtist003 = (System.Int32.Parse(PlayerDatabase.CollectedArtist003) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 10) {
			PlayerDatabase.CollectedArtist003 = (System.Int32.Parse(PlayerDatabase.CollectedArtist003) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 11) {
			PlayerDatabase.CollectedArtist004 = (System.Int32.Parse(PlayerDatabase.CollectedArtist004) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 12) {
			PlayerDatabase.CollectedArtist004 = (System.Int32.Parse(PlayerDatabase.CollectedArtist004) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 13) {
			PlayerDatabase.CollectedArtist004 = (System.Int32.Parse(PlayerDatabase.CollectedArtist004) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 14) {
			PlayerDatabase.CollectedArtist004 = (System.Int32.Parse(PlayerDatabase.CollectedArtist004) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 15) {
			PlayerDatabase.CollectedArtist004 = (System.Int32.Parse(PlayerDatabase.CollectedArtist004) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 16) {
			PlayerDatabase.CollectedArtist005 = (System.Int32.Parse(PlayerDatabase.CollectedArtist005) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 17) {
			PlayerDatabase.CollectedArtist005 = (System.Int32.Parse(PlayerDatabase.CollectedArtist005) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 18) {
			PlayerDatabase.CollectedArtist005 = (System.Int32.Parse(PlayerDatabase.CollectedArtist005) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 19) {
			PlayerDatabase.CollectedArtist006 = (System.Int32.Parse(PlayerDatabase.CollectedArtist006) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 20) {
			PlayerDatabase.CollectedArtist006 = (System.Int32.Parse(PlayerDatabase.CollectedArtist006) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 21) {
			PlayerDatabase.CollectedArtist006 = (System.Int32.Parse(PlayerDatabase.CollectedArtist006) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 22) {
			PlayerDatabase.CollectedArtist006 = (System.Int32.Parse(PlayerDatabase.CollectedArtist006) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 23) {
			PlayerDatabase.CollectedArtist007 = (System.Int32.Parse(PlayerDatabase.CollectedArtist007) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 24) {
			PlayerDatabase.CollectedArtist007 = (System.Int32.Parse(PlayerDatabase.CollectedArtist007) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 25) {
			PlayerDatabase.CollectedArtist007 = (System.Int32.Parse(PlayerDatabase.CollectedArtist007) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 26) {
			PlayerDatabase.CollectedArtist007 = (System.Int32.Parse(PlayerDatabase.CollectedArtist007) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 27) {
			PlayerDatabase.CollectedArtist008 = (System.Int32.Parse(PlayerDatabase.CollectedArtist008) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 28) {
			PlayerDatabase.CollectedArtist008 = (System.Int32.Parse(PlayerDatabase.CollectedArtist008) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 29) {
			PlayerDatabase.CollectedArtist008 = (System.Int32.Parse(PlayerDatabase.CollectedArtist008) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 30) {
			PlayerDatabase.CollectedArtist008 = (System.Int32.Parse(PlayerDatabase.CollectedArtist008) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 31) {
			PlayerDatabase.CollectedArtist008 = (System.Int32.Parse(PlayerDatabase.CollectedArtist008) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 32) {
			PlayerDatabase.CollectedArtist009 = (System.Int32.Parse(PlayerDatabase.CollectedArtist009) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 33) {
			PlayerDatabase.CollectedArtist009 = (System.Int32.Parse(PlayerDatabase.CollectedArtist009) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 34) {
			PlayerDatabase.CollectedArtist009 = (System.Int32.Parse(PlayerDatabase.CollectedArtist009) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 35) {
			PlayerDatabase.CollectedArtist009 = (System.Int32.Parse(PlayerDatabase.CollectedArtist009) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 36) {
			PlayerDatabase.CollectedArtist009 = (System.Int32.Parse(PlayerDatabase.CollectedArtist009) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 37) {
			PlayerDatabase.CollectedArtist010 = (System.Int32.Parse(PlayerDatabase.CollectedArtist010) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 38) {
			PlayerDatabase.CollectedArtist010 = (System.Int32.Parse(PlayerDatabase.CollectedArtist010) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 39) {
			PlayerDatabase.CollectedArtist010 = (System.Int32.Parse(PlayerDatabase.CollectedArtist010) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 40) {
			PlayerDatabase.CollectedArtist010 = (System.Int32.Parse(PlayerDatabase.CollectedArtist010) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 41) {
			PlayerDatabase.CollectedArtist010 = (System.Int32.Parse(PlayerDatabase.CollectedArtist010) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 42) {
			PlayerDatabase.CollectedArtist011 = (System.Int32.Parse(PlayerDatabase.CollectedArtist011) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 43) {
			PlayerDatabase.CollectedArtist011 = (System.Int32.Parse(PlayerDatabase.CollectedArtist011) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 44) {
			PlayerDatabase.CollectedArtist011 = (System.Int32.Parse(PlayerDatabase.CollectedArtist011) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 45) {
			PlayerDatabase.CollectedArtist011 = (System.Int32.Parse(PlayerDatabase.CollectedArtist011) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 46) {
			PlayerDatabase.CollectedArtist011 = (System.Int32.Parse(PlayerDatabase.CollectedArtist011) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 47) {
			PlayerDatabase.CollectedArtist012 = (System.Int32.Parse(PlayerDatabase.CollectedArtist012) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 48) {
			PlayerDatabase.CollectedArtist012 = (System.Int32.Parse(PlayerDatabase.CollectedArtist012) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 49) {
			PlayerDatabase.CollectedArtist012 = (System.Int32.Parse(PlayerDatabase.CollectedArtist012) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 50) {
			PlayerDatabase.CollectedArtist012 = (System.Int32.Parse(PlayerDatabase.CollectedArtist012) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 51) {
			PlayerDatabase.CollectedArtist013 = (System.Int32.Parse(PlayerDatabase.CollectedArtist013) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 52) {
			PlayerDatabase.CollectedArtist013 = (System.Int32.Parse(PlayerDatabase.CollectedArtist013) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 53) {
			PlayerDatabase.CollectedArtist013 = (System.Int32.Parse(PlayerDatabase.CollectedArtist013) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 54) {
			PlayerDatabase.CollectedArtist013 = (System.Int32.Parse(PlayerDatabase.CollectedArtist013) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 55) {
			PlayerDatabase.CollectedArtist013 = (System.Int32.Parse(PlayerDatabase.CollectedArtist013) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 56) {
			PlayerDatabase.CollectedArtist014 = (System.Int32.Parse(PlayerDatabase.CollectedArtist014) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 57) {
			PlayerDatabase.CollectedArtist014 = (System.Int32.Parse(PlayerDatabase.CollectedArtist014) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 58) {
			PlayerDatabase.CollectedArtist014 = (System.Int32.Parse(PlayerDatabase.CollectedArtist014) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 59) {
			PlayerDatabase.CollectedArtist014 = (System.Int32.Parse(PlayerDatabase.CollectedArtist014) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 60) {
			PlayerDatabase.CollectedArtist014 = (System.Int32.Parse(PlayerDatabase.CollectedArtist014) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 61) {
			PlayerDatabase.CollectedArtist015 = (System.Int32.Parse(PlayerDatabase.CollectedArtist015) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 62) {
			PlayerDatabase.CollectedArtist015 = (System.Int32.Parse(PlayerDatabase.CollectedArtist015) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 63) {
			PlayerDatabase.CollectedArtist015 = (System.Int32.Parse(PlayerDatabase.CollectedArtist015) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 64) {
			PlayerDatabase.CollectedArtist015 = (System.Int32.Parse(PlayerDatabase.CollectedArtist015) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 65) {
			PlayerDatabase.CollectedArtist015 = (System.Int32.Parse(PlayerDatabase.CollectedArtist015) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 66) {
			PlayerDatabase.CollectedArtist016 = (System.Int32.Parse(PlayerDatabase.CollectedArtist016) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 67) {
			PlayerDatabase.CollectedArtist016 = (System.Int32.Parse(PlayerDatabase.CollectedArtist016) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 68) {
			PlayerDatabase.CollectedArtist016 = (System.Int32.Parse(PlayerDatabase.CollectedArtist016) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 69) {
			PlayerDatabase.CollectedArtist016 = (System.Int32.Parse(PlayerDatabase.CollectedArtist016) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 70) {
			PlayerDatabase.CollectedArtist016 = (System.Int32.Parse(PlayerDatabase.CollectedArtist016) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 71) {
			PlayerDatabase.CollectedArtist017 = (System.Int32.Parse(PlayerDatabase.CollectedArtist017) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 72) {
			PlayerDatabase.CollectedArtist017 = (System.Int32.Parse(PlayerDatabase.CollectedArtist017) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 73) {
			PlayerDatabase.CollectedArtist017 = (System.Int32.Parse(PlayerDatabase.CollectedArtist017) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 74) {
			PlayerDatabase.CollectedArtist017 = (System.Int32.Parse(PlayerDatabase.CollectedArtist017) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 75) {
			PlayerDatabase.CollectedArtist017 = (System.Int32.Parse(PlayerDatabase.CollectedArtist017) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 76) {
			PlayerDatabase.CollectedArtist018 = (System.Int32.Parse(PlayerDatabase.CollectedArtist018) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 77) {
			PlayerDatabase.CollectedArtist018 = (System.Int32.Parse(PlayerDatabase.CollectedArtist018) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 78) {
			PlayerDatabase.CollectedArtist018 = (System.Int32.Parse(PlayerDatabase.CollectedArtist018) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 79) {
			PlayerDatabase.CollectedArtist018 = (System.Int32.Parse(PlayerDatabase.CollectedArtist018) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 80) {
			PlayerDatabase.CollectedArtist018 = (System.Int32.Parse(PlayerDatabase.CollectedArtist018) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 81) {
			PlayerDatabase.CollectedArtist019 = (System.Int32.Parse(PlayerDatabase.CollectedArtist019) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 82) {
			PlayerDatabase.CollectedArtist019 = (System.Int32.Parse(PlayerDatabase.CollectedArtist019) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 83) {
			PlayerDatabase.CollectedArtist019 = (System.Int32.Parse(PlayerDatabase.CollectedArtist019) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 84) {
			PlayerDatabase.CollectedArtist019 = (System.Int32.Parse(PlayerDatabase.CollectedArtist019) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 85) {
			PlayerDatabase.CollectedArtist019 = (System.Int32.Parse(PlayerDatabase.CollectedArtist019) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 86) {
			PlayerDatabase.CollectedArtist020 = (System.Int32.Parse(PlayerDatabase.CollectedArtist020) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 87) {
			PlayerDatabase.CollectedArtist020 = (System.Int32.Parse(PlayerDatabase.CollectedArtist020) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 88) {
			PlayerDatabase.CollectedArtist020 = (System.Int32.Parse(PlayerDatabase.CollectedArtist020) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 89) {
			PlayerDatabase.CollectedArtist020 = (System.Int32.Parse(PlayerDatabase.CollectedArtist020) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 90) {
			PlayerDatabase.CollectedArtist020 = (System.Int32.Parse(PlayerDatabase.CollectedArtist020) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 91) {
			PlayerDatabase.CollectedArtist021 = (System.Int32.Parse(PlayerDatabase.CollectedArtist021) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 92) {
			PlayerDatabase.CollectedArtist021 = (System.Int32.Parse(PlayerDatabase.CollectedArtist021) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 93) {
			PlayerDatabase.CollectedArtist021 = (System.Int32.Parse(PlayerDatabase.CollectedArtist021) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 94) {
			PlayerDatabase.CollectedArtist021 = (System.Int32.Parse(PlayerDatabase.CollectedArtist021) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 95) {
			PlayerDatabase.CollectedArtist022 = (System.Int32.Parse(PlayerDatabase.CollectedArtist022) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 96) {
			PlayerDatabase.CollectedArtist022 = (System.Int32.Parse(PlayerDatabase.CollectedArtist022) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 97) {
			PlayerDatabase.CollectedArtist022 = (System.Int32.Parse(PlayerDatabase.CollectedArtist022) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 98) {
			PlayerDatabase.CollectedArtist022 = (System.Int32.Parse(PlayerDatabase.CollectedArtist022) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 99) {
			PlayerDatabase.CollectedArtist023 = (System.Int32.Parse(PlayerDatabase.CollectedArtist023) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 100) {
			PlayerDatabase.CollectedArtist023 = (System.Int32.Parse(PlayerDatabase.CollectedArtist023) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 101) {
			PlayerDatabase.CollectedArtist023 = (System.Int32.Parse(PlayerDatabase.CollectedArtist023) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 102) {
			PlayerDatabase.CollectedArtist023 = (System.Int32.Parse(PlayerDatabase.CollectedArtist023) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 103) {
			PlayerDatabase.CollectedArtist024 = (System.Int32.Parse(PlayerDatabase.CollectedArtist024) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 104) {
			PlayerDatabase.CollectedArtist024 = (System.Int32.Parse(PlayerDatabase.CollectedArtist024) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 105) {
			PlayerDatabase.CollectedArtist024 = (System.Int32.Parse(PlayerDatabase.CollectedArtist024) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 106) {
			PlayerDatabase.CollectedArtist024 = (System.Int32.Parse(PlayerDatabase.CollectedArtist024) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 107) {
			PlayerDatabase.CollectedArtist024 = (System.Int32.Parse(PlayerDatabase.CollectedArtist024) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 108) {
			PlayerDatabase.CollectedArtist025 = (System.Int32.Parse(PlayerDatabase.CollectedArtist025) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 109) {
			PlayerDatabase.CollectedArtist025 = (System.Int32.Parse(PlayerDatabase.CollectedArtist025) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 110) {
			PlayerDatabase.CollectedArtist025 = (System.Int32.Parse(PlayerDatabase.CollectedArtist025) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 111) {
			PlayerDatabase.CollectedArtist025 = (System.Int32.Parse(PlayerDatabase.CollectedArtist025) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 112) {
			PlayerDatabase.CollectedArtist025 = (System.Int32.Parse(PlayerDatabase.CollectedArtist025) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 113) {
			PlayerDatabase.CollectedArtist026 = (System.Int32.Parse(PlayerDatabase.CollectedArtist026) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 114) {
			PlayerDatabase.CollectedArtist026 = (System.Int32.Parse(PlayerDatabase.CollectedArtist026) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 115) {
			PlayerDatabase.CollectedArtist026 = (System.Int32.Parse(PlayerDatabase.CollectedArtist026) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 116) {
			PlayerDatabase.CollectedArtist027 = (System.Int32.Parse(PlayerDatabase.CollectedArtist027) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 117) {
			PlayerDatabase.CollectedArtist027 = (System.Int32.Parse(PlayerDatabase.CollectedArtist027) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 118) {
			PlayerDatabase.CollectedArtist027 = (System.Int32.Parse(PlayerDatabase.CollectedArtist027) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 119) {
			PlayerDatabase.CollectedArtist027 = (System.Int32.Parse(PlayerDatabase.CollectedArtist027) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 120) {
			PlayerDatabase.CollectedArtist027 = (System.Int32.Parse(PlayerDatabase.CollectedArtist027) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 121) {
			PlayerDatabase.CollectedArtist028 = (System.Int32.Parse(PlayerDatabase.CollectedArtist028) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 122) {
			PlayerDatabase.CollectedArtist028 = (System.Int32.Parse(PlayerDatabase.CollectedArtist028) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 123) {
			PlayerDatabase.CollectedArtist029 = (System.Int32.Parse(PlayerDatabase.CollectedArtist029) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 124) {
			PlayerDatabase.CollectedArtist029 = (System.Int32.Parse(PlayerDatabase.CollectedArtist029) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 125) {
			PlayerDatabase.CollectedArtist030 = (System.Int32.Parse(PlayerDatabase.CollectedArtist030) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 126) {
			PlayerDatabase.CollectedArtist030 = (System.Int32.Parse(PlayerDatabase.CollectedArtist030) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 127) {
			PlayerDatabase.CollectedArtist030 = (System.Int32.Parse(PlayerDatabase.CollectedArtist030) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 128) {
			PlayerDatabase.CollectedArtist030 = (System.Int32.Parse(PlayerDatabase.CollectedArtist030) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 129) {
			PlayerDatabase.CollectedArtist030 = (System.Int32.Parse(PlayerDatabase.CollectedArtist030) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 130) {
			PlayerDatabase.CollectedArtist031 = (System.Int32.Parse(PlayerDatabase.CollectedArtist031) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 131) {
			PlayerDatabase.CollectedArtist031 = (System.Int32.Parse(PlayerDatabase.CollectedArtist031) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 132) {
			PlayerDatabase.CollectedArtist031 = (System.Int32.Parse(PlayerDatabase.CollectedArtist031) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 133) {
			PlayerDatabase.CollectedArtist031 = (System.Int32.Parse(PlayerDatabase.CollectedArtist031) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 134) {
			PlayerDatabase.CollectedArtist031 = (System.Int32.Parse(PlayerDatabase.CollectedArtist031) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 135) {
			PlayerDatabase.CollectedArtist032 = (System.Int32.Parse(PlayerDatabase.CollectedArtist032) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 136) {
			PlayerDatabase.CollectedArtist032 = (System.Int32.Parse(PlayerDatabase.CollectedArtist032) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 137) {
			PlayerDatabase.CollectedArtist032 = (System.Int32.Parse(PlayerDatabase.CollectedArtist032) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 138) {
			PlayerDatabase.CollectedArtist032 = (System.Int32.Parse(PlayerDatabase.CollectedArtist032) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 139) {
			PlayerDatabase.CollectedArtist032 = (System.Int32.Parse(PlayerDatabase.CollectedArtist032) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 140) {
			PlayerDatabase.CollectedArtist033 = (System.Int32.Parse(PlayerDatabase.CollectedArtist033) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 141) {
			PlayerDatabase.CollectedArtist033 = (System.Int32.Parse(PlayerDatabase.CollectedArtist033) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 142) {
			PlayerDatabase.CollectedArtist033 = (System.Int32.Parse(PlayerDatabase.CollectedArtist033) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 143) {
			PlayerDatabase.CollectedArtist033 = (System.Int32.Parse(PlayerDatabase.CollectedArtist033) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 144) {
			PlayerDatabase.CollectedArtist034 = (System.Int32.Parse(PlayerDatabase.CollectedArtist034) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 145) {
			PlayerDatabase.CollectedArtist034 = (System.Int32.Parse(PlayerDatabase.CollectedArtist034) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 146) {
			PlayerDatabase.CollectedArtist034 = (System.Int32.Parse(PlayerDatabase.CollectedArtist034) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 147) {
			PlayerDatabase.CollectedArtist034 = (System.Int32.Parse(PlayerDatabase.CollectedArtist034) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 148) {
			PlayerDatabase.CollectedArtist035 = (System.Int32.Parse(PlayerDatabase.CollectedArtist035) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 149) {
			PlayerDatabase.CollectedArtist035 = (System.Int32.Parse(PlayerDatabase.CollectedArtist035) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 150) {
			PlayerDatabase.CollectedArtist035 = (System.Int32.Parse(PlayerDatabase.CollectedArtist035) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 151) {
			PlayerDatabase.CollectedArtist035 = (System.Int32.Parse(PlayerDatabase.CollectedArtist035) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 152) {
			PlayerDatabase.CollectedArtist035 = (System.Int32.Parse(PlayerDatabase.CollectedArtist035) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 153) {
			PlayerDatabase.CollectedArtist036 = (System.Int32.Parse(PlayerDatabase.CollectedArtist036) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 154) {
			PlayerDatabase.CollectedArtist036 = (System.Int32.Parse(PlayerDatabase.CollectedArtist036) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 155) {
			PlayerDatabase.CollectedArtist036 = (System.Int32.Parse(PlayerDatabase.CollectedArtist036) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 156) {
			PlayerDatabase.CollectedArtist036 = (System.Int32.Parse(PlayerDatabase.CollectedArtist036) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 157) {
			PlayerDatabase.CollectedArtist036 = (System.Int32.Parse(PlayerDatabase.CollectedArtist036) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 158) {
			PlayerDatabase.CollectedArtist037 = (System.Int32.Parse(PlayerDatabase.CollectedArtist037) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 159) {
			PlayerDatabase.CollectedArtist037 = (System.Int32.Parse(PlayerDatabase.CollectedArtist037) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 160) {
			PlayerDatabase.CollectedArtist037 = (System.Int32.Parse(PlayerDatabase.CollectedArtist037) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 161) {
			PlayerDatabase.CollectedArtist037 = (System.Int32.Parse(PlayerDatabase.CollectedArtist037) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 162) {
			PlayerDatabase.CollectedArtist037 = (System.Int32.Parse(PlayerDatabase.CollectedArtist037) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 163) {
			PlayerDatabase.CollectedArtist038 = (System.Int32.Parse(PlayerDatabase.CollectedArtist038) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 164) {
			PlayerDatabase.CollectedArtist038 = (System.Int32.Parse(PlayerDatabase.CollectedArtist038) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 165) {
			PlayerDatabase.CollectedArtist038 = (System.Int32.Parse(PlayerDatabase.CollectedArtist038) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 166) {
			PlayerDatabase.CollectedArtist039 = (System.Int32.Parse(PlayerDatabase.CollectedArtist039) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 167) {
			PlayerDatabase.CollectedArtist039 = (System.Int32.Parse(PlayerDatabase.CollectedArtist039) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 168) {
			PlayerDatabase.CollectedArtist039 = (System.Int32.Parse(PlayerDatabase.CollectedArtist039) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 169) {
			PlayerDatabase.CollectedArtist040 = (System.Int32.Parse(PlayerDatabase.CollectedArtist040) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 170) {
			PlayerDatabase.CollectedArtist040 = (System.Int32.Parse(PlayerDatabase.CollectedArtist040) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 171) {
			PlayerDatabase.CollectedArtist040 = (System.Int32.Parse(PlayerDatabase.CollectedArtist040) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 172) {
			PlayerDatabase.CollectedArtist041 = (System.Int32.Parse(PlayerDatabase.CollectedArtist041) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 173) {
			PlayerDatabase.CollectedArtist041 = (System.Int32.Parse(PlayerDatabase.CollectedArtist041) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 174) {
			PlayerDatabase.CollectedArtist041 = (System.Int32.Parse(PlayerDatabase.CollectedArtist041) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 175) {
			PlayerDatabase.CollectedArtist041 = (System.Int32.Parse(PlayerDatabase.CollectedArtist041) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 176) {
			PlayerDatabase.CollectedArtist042 = (System.Int32.Parse(PlayerDatabase.CollectedArtist042) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 177) {
			PlayerDatabase.CollectedArtist042 = (System.Int32.Parse(PlayerDatabase.CollectedArtist042) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 178) {
			PlayerDatabase.CollectedArtist042 = (System.Int32.Parse(PlayerDatabase.CollectedArtist042) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 179) {
			PlayerDatabase.CollectedArtist042 = (System.Int32.Parse(PlayerDatabase.CollectedArtist042) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 180) {
			PlayerDatabase.CollectedArtist042 = (System.Int32.Parse(PlayerDatabase.CollectedArtist042) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 181) {
			PlayerDatabase.CollectedArtist043 = (System.Int32.Parse(PlayerDatabase.CollectedArtist043) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 182) {
			PlayerDatabase.CollectedArtist043 = (System.Int32.Parse(PlayerDatabase.CollectedArtist043) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 183) {
			PlayerDatabase.CollectedArtist043 = (System.Int32.Parse(PlayerDatabase.CollectedArtist043) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 184) {
			PlayerDatabase.CollectedArtist043 = (System.Int32.Parse(PlayerDatabase.CollectedArtist043) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 185) {
			PlayerDatabase.CollectedArtist043 = (System.Int32.Parse(PlayerDatabase.CollectedArtist043) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 186) {
			PlayerDatabase.CollectedArtist044 = (System.Int32.Parse(PlayerDatabase.CollectedArtist044) + 1).ToString();
		}

		else if (RandomArtistCollectInt == 187) {
			PlayerDatabase.CollectedArtist044 = (System.Int32.Parse(PlayerDatabase.CollectedArtist044) + 1).ToString();
		}
	}

	public IEnumerator SettingPlayerData() {
		WWWForm SettingPlayerDataForm = new WWWForm();
		SettingPlayerDataForm.AddField("PlayerUsername", PlayerDatabase.PlayerUsername);
		SettingPlayerDataForm.AddField("PlayerFirstName", PlayerDatabase.PlayerFirstName);
		SettingPlayerDataForm.AddField("PlayerFavArtist", PlayerDatabase.PlayerFavArtist);
		SettingPlayerDataForm.AddField("PlayerVsCpuWin", PlayerDatabase.PlayerVsCpuWin);
		SettingPlayerDataForm.AddField("PlayerVsCpuLoss", PlayerDatabase.PlayerVsCpuLoss);
		SettingPlayerDataForm.AddField("PlayerVsPlayerWin", PlayerDatabase.PlayerVsPlayerWin);
		SettingPlayerDataForm.AddField("PlayerVsPlayerLoss", PlayerDatabase.PlayerVsPlayerLoss);
		SettingPlayerDataForm.AddField("PlayerCoinAmount", PlayerDatabase.PlayerCoinAmount);
		SettingPlayerDataForm.AddField("PlayerDailyLogin", PlayerDatabase.PlayerDailyLogin);
		SettingPlayerDataForm.AddField("PlayerCollectLevelReward", PlayerDatabase.PlayerCollectLevelReward);

		SettingPlayerDataForm.AddField("CollectedArtwork001", PlayerDatabase.CollectedArtwork001);
		SettingPlayerDataForm.AddField("CollectedArtwork002", PlayerDatabase.CollectedArtwork002);
		SettingPlayerDataForm.AddField("CollectedArtwork003", PlayerDatabase.CollectedArtwork003);
		SettingPlayerDataForm.AddField("CollectedArtwork004", PlayerDatabase.CollectedArtwork004);
		SettingPlayerDataForm.AddField("CollectedArtwork005", PlayerDatabase.CollectedArtwork005);
		SettingPlayerDataForm.AddField("CollectedArtwork006", PlayerDatabase.CollectedArtwork006);
		SettingPlayerDataForm.AddField("CollectedArtwork007", PlayerDatabase.CollectedArtwork007);
		SettingPlayerDataForm.AddField("CollectedArtwork008", PlayerDatabase.CollectedArtwork008);
		SettingPlayerDataForm.AddField("CollectedArtwork009", PlayerDatabase.CollectedArtwork009);
		SettingPlayerDataForm.AddField("CollectedArtwork010", PlayerDatabase.CollectedArtwork010);
		SettingPlayerDataForm.AddField("CollectedArtwork011", PlayerDatabase.CollectedArtwork011);
		SettingPlayerDataForm.AddField("CollectedArtwork012", PlayerDatabase.CollectedArtwork012);
		SettingPlayerDataForm.AddField("CollectedArtwork013", PlayerDatabase.CollectedArtwork013);
		SettingPlayerDataForm.AddField("CollectedArtwork014", PlayerDatabase.CollectedArtwork014);
		SettingPlayerDataForm.AddField("CollectedArtwork015", PlayerDatabase.CollectedArtwork015);
		SettingPlayerDataForm.AddField("CollectedArtwork016", PlayerDatabase.CollectedArtwork016);
		SettingPlayerDataForm.AddField("CollectedArtwork017", PlayerDatabase.CollectedArtwork017);
		SettingPlayerDataForm.AddField("CollectedArtwork018", PlayerDatabase.CollectedArtwork018);
		SettingPlayerDataForm.AddField("CollectedArtwork019", PlayerDatabase.CollectedArtwork019);
		SettingPlayerDataForm.AddField("CollectedArtwork020", PlayerDatabase.CollectedArtwork020);
		SettingPlayerDataForm.AddField("CollectedArtwork021", PlayerDatabase.CollectedArtwork021);
		SettingPlayerDataForm.AddField("CollectedArtwork022", PlayerDatabase.CollectedArtwork022);
		SettingPlayerDataForm.AddField("CollectedArtwork023", PlayerDatabase.CollectedArtwork023);
		SettingPlayerDataForm.AddField("CollectedArtwork024", PlayerDatabase.CollectedArtwork024);
		SettingPlayerDataForm.AddField("CollectedArtwork025", PlayerDatabase.CollectedArtwork025);
		SettingPlayerDataForm.AddField("CollectedArtwork026", PlayerDatabase.CollectedArtwork026);
		SettingPlayerDataForm.AddField("CollectedArtwork027", PlayerDatabase.CollectedArtwork027);
		SettingPlayerDataForm.AddField("CollectedArtwork028", PlayerDatabase.CollectedArtwork028);
		SettingPlayerDataForm.AddField("CollectedArtwork029", PlayerDatabase.CollectedArtwork029);
		SettingPlayerDataForm.AddField("CollectedArtwork030", PlayerDatabase.CollectedArtwork030);
		SettingPlayerDataForm.AddField("CollectedArtwork031", PlayerDatabase.CollectedArtwork031);
		SettingPlayerDataForm.AddField("CollectedArtwork032", PlayerDatabase.CollectedArtwork032);
		SettingPlayerDataForm.AddField("CollectedArtwork033", PlayerDatabase.CollectedArtwork033);
		SettingPlayerDataForm.AddField("CollectedArtwork034", PlayerDatabase.CollectedArtwork034);
		SettingPlayerDataForm.AddField("CollectedArtwork035", PlayerDatabase.CollectedArtwork035);
		SettingPlayerDataForm.AddField("CollectedArtwork036", PlayerDatabase.CollectedArtwork036);
		SettingPlayerDataForm.AddField("CollectedArtwork037", PlayerDatabase.CollectedArtwork037);
		SettingPlayerDataForm.AddField("CollectedArtwork038", PlayerDatabase.CollectedArtwork038);
		SettingPlayerDataForm.AddField("CollectedArtwork039", PlayerDatabase.CollectedArtwork039);
		SettingPlayerDataForm.AddField("CollectedArtwork040", PlayerDatabase.CollectedArtwork040);
		SettingPlayerDataForm.AddField("CollectedArtwork041", PlayerDatabase.CollectedArtwork041);
		SettingPlayerDataForm.AddField("CollectedArtwork042", PlayerDatabase.CollectedArtwork042);
		SettingPlayerDataForm.AddField("CollectedArtwork043", PlayerDatabase.CollectedArtwork043);
		SettingPlayerDataForm.AddField("CollectedArtwork044", PlayerDatabase.CollectedArtwork044);
		SettingPlayerDataForm.AddField("CollectedArtwork045", PlayerDatabase.CollectedArtwork045);
		SettingPlayerDataForm.AddField("CollectedArtwork046", PlayerDatabase.CollectedArtwork046);
		SettingPlayerDataForm.AddField("CollectedArtwork047", PlayerDatabase.CollectedArtwork047);
		SettingPlayerDataForm.AddField("CollectedArtwork048", PlayerDatabase.CollectedArtwork048);
		SettingPlayerDataForm.AddField("CollectedArtwork049", PlayerDatabase.CollectedArtwork049);
		SettingPlayerDataForm.AddField("CollectedArtwork050", PlayerDatabase.CollectedArtwork050);
		SettingPlayerDataForm.AddField("CollectedArtwork051", PlayerDatabase.CollectedArtwork051);
		SettingPlayerDataForm.AddField("CollectedArtwork052", PlayerDatabase.CollectedArtwork052);
		SettingPlayerDataForm.AddField("CollectedArtwork053", PlayerDatabase.CollectedArtwork053);
		SettingPlayerDataForm.AddField("CollectedArtwork054", PlayerDatabase.CollectedArtwork054);
		SettingPlayerDataForm.AddField("CollectedArtwork055", PlayerDatabase.CollectedArtwork055);
		SettingPlayerDataForm.AddField("CollectedArtwork056", PlayerDatabase.CollectedArtwork056);
		SettingPlayerDataForm.AddField("CollectedArtwork057", PlayerDatabase.CollectedArtwork057);
		SettingPlayerDataForm.AddField("CollectedArtwork058", PlayerDatabase.CollectedArtwork058);
		SettingPlayerDataForm.AddField("CollectedArtwork059", PlayerDatabase.CollectedArtwork059);
		SettingPlayerDataForm.AddField("CollectedArtwork060", PlayerDatabase.CollectedArtwork060);
		SettingPlayerDataForm.AddField("CollectedArtwork061", PlayerDatabase.CollectedArtwork061);
		SettingPlayerDataForm.AddField("CollectedArtwork062", PlayerDatabase.CollectedArtwork062);
		SettingPlayerDataForm.AddField("CollectedArtwork063", PlayerDatabase.CollectedArtwork063);
		SettingPlayerDataForm.AddField("CollectedArtwork064", PlayerDatabase.CollectedArtwork064);
		SettingPlayerDataForm.AddField("CollectedArtwork065", PlayerDatabase.CollectedArtwork065);
		SettingPlayerDataForm.AddField("CollectedArtwork066", PlayerDatabase.CollectedArtwork066);
		SettingPlayerDataForm.AddField("CollectedArtwork067", PlayerDatabase.CollectedArtwork067);
		SettingPlayerDataForm.AddField("CollectedArtwork068", PlayerDatabase.CollectedArtwork068);
		SettingPlayerDataForm.AddField("CollectedArtwork069", PlayerDatabase.CollectedArtwork069);
		SettingPlayerDataForm.AddField("CollectedArtwork070", PlayerDatabase.CollectedArtwork070);
		SettingPlayerDataForm.AddField("CollectedArtwork071", PlayerDatabase.CollectedArtwork071);
		SettingPlayerDataForm.AddField("CollectedArtwork072", PlayerDatabase.CollectedArtwork072);
		SettingPlayerDataForm.AddField("CollectedArtwork073", PlayerDatabase.CollectedArtwork073);
		SettingPlayerDataForm.AddField("CollectedArtwork074", PlayerDatabase.CollectedArtwork074);
		SettingPlayerDataForm.AddField("CollectedArtwork075", PlayerDatabase.CollectedArtwork075);
		SettingPlayerDataForm.AddField("CollectedArtwork076", PlayerDatabase.CollectedArtwork076);
		SettingPlayerDataForm.AddField("CollectedArtwork077", PlayerDatabase.CollectedArtwork077);
		SettingPlayerDataForm.AddField("CollectedArtwork078", PlayerDatabase.CollectedArtwork078);
		SettingPlayerDataForm.AddField("CollectedArtwork079", PlayerDatabase.CollectedArtwork079);
		SettingPlayerDataForm.AddField("CollectedArtwork080", PlayerDatabase.CollectedArtwork080);
		SettingPlayerDataForm.AddField("CollectedArtwork081", PlayerDatabase.CollectedArtwork081);
		SettingPlayerDataForm.AddField("CollectedArtwork082", PlayerDatabase.CollectedArtwork082);
		SettingPlayerDataForm.AddField("CollectedArtwork083", PlayerDatabase.CollectedArtwork083);
		SettingPlayerDataForm.AddField("CollectedArtwork084", PlayerDatabase.CollectedArtwork084);
		SettingPlayerDataForm.AddField("CollectedArtwork085", PlayerDatabase.CollectedArtwork085);
		SettingPlayerDataForm.AddField("CollectedArtwork086", PlayerDatabase.CollectedArtwork086);
		SettingPlayerDataForm.AddField("CollectedArtwork087", PlayerDatabase.CollectedArtwork087);
		SettingPlayerDataForm.AddField("CollectedArtwork088", PlayerDatabase.CollectedArtwork088);
		SettingPlayerDataForm.AddField("CollectedArtwork089", PlayerDatabase.CollectedArtwork089);
		SettingPlayerDataForm.AddField("CollectedArtwork090", PlayerDatabase.CollectedArtwork090);
		SettingPlayerDataForm.AddField("CollectedArtwork091", PlayerDatabase.CollectedArtwork091);
		SettingPlayerDataForm.AddField("CollectedArtwork092", PlayerDatabase.CollectedArtwork092);
		SettingPlayerDataForm.AddField("CollectedArtwork093", PlayerDatabase.CollectedArtwork093);
		SettingPlayerDataForm.AddField("CollectedArtwork094", PlayerDatabase.CollectedArtwork094);
		SettingPlayerDataForm.AddField("CollectedArtwork095", PlayerDatabase.CollectedArtwork095);
		SettingPlayerDataForm.AddField("CollectedArtwork096", PlayerDatabase.CollectedArtwork096);
		SettingPlayerDataForm.AddField("CollectedArtwork097", PlayerDatabase.CollectedArtwork097);
		SettingPlayerDataForm.AddField("CollectedArtwork098", PlayerDatabase.CollectedArtwork098);
		SettingPlayerDataForm.AddField("CollectedArtwork099", PlayerDatabase.CollectedArtwork099);
		SettingPlayerDataForm.AddField("CollectedArtwork100", PlayerDatabase.CollectedArtwork100);
		SettingPlayerDataForm.AddField("CollectedArtwork101", PlayerDatabase.CollectedArtwork101);
		SettingPlayerDataForm.AddField("CollectedArtwork102", PlayerDatabase.CollectedArtwork102);
		SettingPlayerDataForm.AddField("CollectedArtwork103", PlayerDatabase.CollectedArtwork103);
		SettingPlayerDataForm.AddField("CollectedArtwork104", PlayerDatabase.CollectedArtwork104);
		SettingPlayerDataForm.AddField("CollectedArtwork105", PlayerDatabase.CollectedArtwork105);
		SettingPlayerDataForm.AddField("CollectedArtwork106", PlayerDatabase.CollectedArtwork106);
		SettingPlayerDataForm.AddField("CollectedArtwork107", PlayerDatabase.CollectedArtwork107);
		SettingPlayerDataForm.AddField("CollectedArtwork108", PlayerDatabase.CollectedArtwork108);
		SettingPlayerDataForm.AddField("CollectedArtwork109", PlayerDatabase.CollectedArtwork109);
		SettingPlayerDataForm.AddField("CollectedArtwork110", PlayerDatabase.CollectedArtwork110);
		SettingPlayerDataForm.AddField("CollectedArtwork111", PlayerDatabase.CollectedArtwork111);
		SettingPlayerDataForm.AddField("CollectedArtwork112", PlayerDatabase.CollectedArtwork112);
		SettingPlayerDataForm.AddField("CollectedArtwork113", PlayerDatabase.CollectedArtwork113);
		SettingPlayerDataForm.AddField("CollectedArtwork114", PlayerDatabase.CollectedArtwork114);
		SettingPlayerDataForm.AddField("CollectedArtwork115", PlayerDatabase.CollectedArtwork115);
		SettingPlayerDataForm.AddField("CollectedArtwork116", PlayerDatabase.CollectedArtwork116);
		SettingPlayerDataForm.AddField("CollectedArtwork117", PlayerDatabase.CollectedArtwork117);
		SettingPlayerDataForm.AddField("CollectedArtwork118", PlayerDatabase.CollectedArtwork118);
		SettingPlayerDataForm.AddField("CollectedArtwork119", PlayerDatabase.CollectedArtwork119);
		SettingPlayerDataForm.AddField("CollectedArtwork120", PlayerDatabase.CollectedArtwork120);
		SettingPlayerDataForm.AddField("CollectedArtwork121", PlayerDatabase.CollectedArtwork121);
		SettingPlayerDataForm.AddField("CollectedArtwork122", PlayerDatabase.CollectedArtwork122);
		SettingPlayerDataForm.AddField("CollectedArtwork123", PlayerDatabase.CollectedArtwork123);
		SettingPlayerDataForm.AddField("CollectedArtwork124", PlayerDatabase.CollectedArtwork124);
		SettingPlayerDataForm.AddField("CollectedArtwork125", PlayerDatabase.CollectedArtwork125);
		SettingPlayerDataForm.AddField("CollectedArtwork126", PlayerDatabase.CollectedArtwork126);
		SettingPlayerDataForm.AddField("CollectedArtwork127", PlayerDatabase.CollectedArtwork127);
		SettingPlayerDataForm.AddField("CollectedArtwork128", PlayerDatabase.CollectedArtwork128);
		SettingPlayerDataForm.AddField("CollectedArtwork129", PlayerDatabase.CollectedArtwork129);
		SettingPlayerDataForm.AddField("CollectedArtwork130", PlayerDatabase.CollectedArtwork130);
		SettingPlayerDataForm.AddField("CollectedArtwork131", PlayerDatabase.CollectedArtwork131);
		SettingPlayerDataForm.AddField("CollectedArtwork132", PlayerDatabase.CollectedArtwork132);
		SettingPlayerDataForm.AddField("CollectedArtwork133", PlayerDatabase.CollectedArtwork133);
		SettingPlayerDataForm.AddField("CollectedArtwork134", PlayerDatabase.CollectedArtwork134);
		SettingPlayerDataForm.AddField("CollectedArtwork135", PlayerDatabase.CollectedArtwork135);
		SettingPlayerDataForm.AddField("CollectedArtwork136", PlayerDatabase.CollectedArtwork136);
		SettingPlayerDataForm.AddField("CollectedArtwork137", PlayerDatabase.CollectedArtwork137);
		SettingPlayerDataForm.AddField("CollectedArtwork138", PlayerDatabase.CollectedArtwork138);
		SettingPlayerDataForm.AddField("CollectedArtwork139", PlayerDatabase.CollectedArtwork139);
		SettingPlayerDataForm.AddField("CollectedArtwork140", PlayerDatabase.CollectedArtwork140);
		SettingPlayerDataForm.AddField("CollectedArtwork141", PlayerDatabase.CollectedArtwork141);
		SettingPlayerDataForm.AddField("CollectedArtwork142", PlayerDatabase.CollectedArtwork142);
		SettingPlayerDataForm.AddField("CollectedArtwork143", PlayerDatabase.CollectedArtwork143);
		SettingPlayerDataForm.AddField("CollectedArtwork144", PlayerDatabase.CollectedArtwork144);
		SettingPlayerDataForm.AddField("CollectedArtwork145", PlayerDatabase.CollectedArtwork145);
		SettingPlayerDataForm.AddField("CollectedArtwork146", PlayerDatabase.CollectedArtwork146);
		SettingPlayerDataForm.AddField("CollectedArtwork147", PlayerDatabase.CollectedArtwork147);
		SettingPlayerDataForm.AddField("CollectedArtwork148", PlayerDatabase.CollectedArtwork148);
		SettingPlayerDataForm.AddField("CollectedArtwork149", PlayerDatabase.CollectedArtwork149);
		SettingPlayerDataForm.AddField("CollectedArtwork150", PlayerDatabase.CollectedArtwork150);
		SettingPlayerDataForm.AddField("CollectedArtwork151", PlayerDatabase.CollectedArtwork151);
		SettingPlayerDataForm.AddField("CollectedArtwork152", PlayerDatabase.CollectedArtwork152);
		SettingPlayerDataForm.AddField("CollectedArtwork153", PlayerDatabase.CollectedArtwork153);
		SettingPlayerDataForm.AddField("CollectedArtwork154", PlayerDatabase.CollectedArtwork154);
		SettingPlayerDataForm.AddField("CollectedArtwork155", PlayerDatabase.CollectedArtwork155);
		SettingPlayerDataForm.AddField("CollectedArtwork156", PlayerDatabase.CollectedArtwork156);
		SettingPlayerDataForm.AddField("CollectedArtwork157", PlayerDatabase.CollectedArtwork157);
		SettingPlayerDataForm.AddField("CollectedArtwork158", PlayerDatabase.CollectedArtwork158);
		SettingPlayerDataForm.AddField("CollectedArtwork159", PlayerDatabase.CollectedArtwork159);
		SettingPlayerDataForm.AddField("CollectedArtwork160", PlayerDatabase.CollectedArtwork160);
		SettingPlayerDataForm.AddField("CollectedArtwork161", PlayerDatabase.CollectedArtwork161);
		SettingPlayerDataForm.AddField("CollectedArtwork162", PlayerDatabase.CollectedArtwork162);
		SettingPlayerDataForm.AddField("CollectedArtwork163", PlayerDatabase.CollectedArtwork163);
		SettingPlayerDataForm.AddField("CollectedArtwork164", PlayerDatabase.CollectedArtwork164);
		SettingPlayerDataForm.AddField("CollectedArtwork165", PlayerDatabase.CollectedArtwork165);
		SettingPlayerDataForm.AddField("CollectedArtwork166", PlayerDatabase.CollectedArtwork166);
		SettingPlayerDataForm.AddField("CollectedArtwork167", PlayerDatabase.CollectedArtwork167);
		SettingPlayerDataForm.AddField("CollectedArtwork168", PlayerDatabase.CollectedArtwork168);
		SettingPlayerDataForm.AddField("CollectedArtwork169", PlayerDatabase.CollectedArtwork169);
		SettingPlayerDataForm.AddField("CollectedArtwork170", PlayerDatabase.CollectedArtwork170);
		SettingPlayerDataForm.AddField("CollectedArtwork171", PlayerDatabase.CollectedArtwork171);
		SettingPlayerDataForm.AddField("CollectedArtwork172", PlayerDatabase.CollectedArtwork172);
		SettingPlayerDataForm.AddField("CollectedArtwork173", PlayerDatabase.CollectedArtwork173);
		SettingPlayerDataForm.AddField("CollectedArtwork174", PlayerDatabase.CollectedArtwork174);
		SettingPlayerDataForm.AddField("CollectedArtwork175", PlayerDatabase.CollectedArtwork175);
		SettingPlayerDataForm.AddField("CollectedArtwork176", PlayerDatabase.CollectedArtwork176);
		SettingPlayerDataForm.AddField("CollectedArtwork177", PlayerDatabase.CollectedArtwork177);
		SettingPlayerDataForm.AddField("CollectedArtwork178", PlayerDatabase.CollectedArtwork178);
		SettingPlayerDataForm.AddField("CollectedArtwork179", PlayerDatabase.CollectedArtwork179);
		SettingPlayerDataForm.AddField("CollectedArtwork180", PlayerDatabase.CollectedArtwork180);
		SettingPlayerDataForm.AddField("CollectedArtwork181", PlayerDatabase.CollectedArtwork181);
		SettingPlayerDataForm.AddField("CollectedArtwork182", PlayerDatabase.CollectedArtwork182);
		SettingPlayerDataForm.AddField("CollectedArtwork183", PlayerDatabase.CollectedArtwork183);
		SettingPlayerDataForm.AddField("CollectedArtwork184", PlayerDatabase.CollectedArtwork184);
		SettingPlayerDataForm.AddField("CollectedArtwork185", PlayerDatabase.CollectedArtwork185);
		SettingPlayerDataForm.AddField("CollectedArtwork186", PlayerDatabase.CollectedArtwork186);
		SettingPlayerDataForm.AddField("CollectedArtwork187", PlayerDatabase.CollectedArtwork187);
		SettingPlayerDataForm.AddField("CollectedArtwork188", PlayerDatabase.CollectedArtwork188);
		SettingPlayerDataForm.AddField("CollectedArtwork189", PlayerDatabase.CollectedArtwork189);
		SettingPlayerDataForm.AddField("CollectedArtwork190", PlayerDatabase.CollectedArtwork190);
		SettingPlayerDataForm.AddField("CollectedArtwork191", PlayerDatabase.CollectedArtwork191);
		SettingPlayerDataForm.AddField("CollectedArtwork192", PlayerDatabase.CollectedArtwork192);
		SettingPlayerDataForm.AddField("CollectedArtwork193", PlayerDatabase.CollectedArtwork193);
		SettingPlayerDataForm.AddField("CollectedArtwork194", PlayerDatabase.CollectedArtwork194);
		SettingPlayerDataForm.AddField("CollectedArtwork195", PlayerDatabase.CollectedArtwork195);
		SettingPlayerDataForm.AddField("CollectedArtwork196", PlayerDatabase.CollectedArtwork196);
		SettingPlayerDataForm.AddField("CollectedArtwork197", PlayerDatabase.CollectedArtwork197);
		SettingPlayerDataForm.AddField("CollectedArtwork198", PlayerDatabase.CollectedArtwork198);
		SettingPlayerDataForm.AddField("CollectedArtwork199", PlayerDatabase.CollectedArtwork199);
		SettingPlayerDataForm.AddField("CollectedArtwork200", PlayerDatabase.CollectedArtwork200);
		SettingPlayerDataForm.AddField("CollectedArtwork201", PlayerDatabase.CollectedArtwork201);
		SettingPlayerDataForm.AddField("CollectedArtwork202", PlayerDatabase.CollectedArtwork202);
		SettingPlayerDataForm.AddField("CollectedArtwork203", PlayerDatabase.CollectedArtwork203);
		SettingPlayerDataForm.AddField("CollectedArtwork204", PlayerDatabase.CollectedArtwork204);
		SettingPlayerDataForm.AddField("CollectedArtwork205", PlayerDatabase.CollectedArtwork205);
		SettingPlayerDataForm.AddField("CollectedArtwork206", PlayerDatabase.CollectedArtwork206);
		SettingPlayerDataForm.AddField("CollectedArtwork207", PlayerDatabase.CollectedArtwork207);
		SettingPlayerDataForm.AddField("CollectedArtwork208", PlayerDatabase.CollectedArtwork208);
		SettingPlayerDataForm.AddField("CollectedArtwork209", PlayerDatabase.CollectedArtwork209);
		SettingPlayerDataForm.AddField("CollectedArtwork210", PlayerDatabase.CollectedArtwork210);
		SettingPlayerDataForm.AddField("CollectedArtwork211", PlayerDatabase.CollectedArtwork211);
		SettingPlayerDataForm.AddField("CollectedArtwork212", PlayerDatabase.CollectedArtwork212);
		SettingPlayerDataForm.AddField("CollectedArtwork213", PlayerDatabase.CollectedArtwork213);
		SettingPlayerDataForm.AddField("CollectedArtwork214", PlayerDatabase.CollectedArtwork214);
		SettingPlayerDataForm.AddField("CollectedArtwork215", PlayerDatabase.CollectedArtwork215);
		SettingPlayerDataForm.AddField("CollectedArtwork216", PlayerDatabase.CollectedArtwork216);
		SettingPlayerDataForm.AddField("CollectedArtwork217", PlayerDatabase.CollectedArtwork217);
		SettingPlayerDataForm.AddField("CollectedArtwork218", PlayerDatabase.CollectedArtwork218);
		SettingPlayerDataForm.AddField("CollectedArtwork219", PlayerDatabase.CollectedArtwork219);
		SettingPlayerDataForm.AddField("CollectedArtwork220", PlayerDatabase.CollectedArtwork220);
		SettingPlayerDataForm.AddField("CollectedArtwork221", PlayerDatabase.CollectedArtwork221);
		SettingPlayerDataForm.AddField("CollectedArtwork222", PlayerDatabase.CollectedArtwork222);
		SettingPlayerDataForm.AddField("CollectedArtwork223", PlayerDatabase.CollectedArtwork223);
		SettingPlayerDataForm.AddField("CollectedArtwork224", PlayerDatabase.CollectedArtwork224);
		SettingPlayerDataForm.AddField("CollectedArtwork225", PlayerDatabase.CollectedArtwork225);
		SettingPlayerDataForm.AddField("CollectedArtwork226", PlayerDatabase.CollectedArtwork226);
		SettingPlayerDataForm.AddField("CollectedArtwork227", PlayerDatabase.CollectedArtwork227);
		SettingPlayerDataForm.AddField("CollectedArtwork228", PlayerDatabase.CollectedArtwork228);
		SettingPlayerDataForm.AddField("CollectedArtwork229", PlayerDatabase.CollectedArtwork229);
		SettingPlayerDataForm.AddField("CollectedArtwork230", PlayerDatabase.CollectedArtwork230);
		SettingPlayerDataForm.AddField("CollectedArtwork231", PlayerDatabase.CollectedArtwork231);
		SettingPlayerDataForm.AddField("CollectedArtwork232", PlayerDatabase.CollectedArtwork232);
		SettingPlayerDataForm.AddField("CollectedArtwork233", PlayerDatabase.CollectedArtwork233);
		SettingPlayerDataForm.AddField("CollectedArtwork234", PlayerDatabase.CollectedArtwork234);
		SettingPlayerDataForm.AddField("CollectedArtwork235", PlayerDatabase.CollectedArtwork235);
		SettingPlayerDataForm.AddField("CollectedArtwork236", PlayerDatabase.CollectedArtwork236);
		SettingPlayerDataForm.AddField("CollectedArtwork237", PlayerDatabase.CollectedArtwork237);
		SettingPlayerDataForm.AddField("CollectedArtwork238", PlayerDatabase.CollectedArtwork238);
		SettingPlayerDataForm.AddField("CollectedArtwork239", PlayerDatabase.CollectedArtwork239);
		SettingPlayerDataForm.AddField("CollectedArtwork240", PlayerDatabase.CollectedArtwork240);
		SettingPlayerDataForm.AddField("CollectedArtwork241", PlayerDatabase.CollectedArtwork241);
		SettingPlayerDataForm.AddField("CollectedArtwork242", PlayerDatabase.CollectedArtwork242);
		SettingPlayerDataForm.AddField("CollectedArtwork243", PlayerDatabase.CollectedArtwork243);
		SettingPlayerDataForm.AddField("CollectedArtwork244", PlayerDatabase.CollectedArtwork244);
		SettingPlayerDataForm.AddField("CollectedArtwork245", PlayerDatabase.CollectedArtwork245);
		SettingPlayerDataForm.AddField("CollectedArtwork246", PlayerDatabase.CollectedArtwork246);
		SettingPlayerDataForm.AddField("CollectedArtwork247", PlayerDatabase.CollectedArtwork247);
		SettingPlayerDataForm.AddField("CollectedArtwork248", PlayerDatabase.CollectedArtwork248);
		SettingPlayerDataForm.AddField("CollectedArtwork249", PlayerDatabase.CollectedArtwork249);
		SettingPlayerDataForm.AddField("CollectedArtwork250", PlayerDatabase.CollectedArtwork250);
		SettingPlayerDataForm.AddField("CollectedArtwork251", PlayerDatabase.CollectedArtwork251);
		SettingPlayerDataForm.AddField("CollectedArtwork252", PlayerDatabase.CollectedArtwork252);
		SettingPlayerDataForm.AddField("CollectedArtwork253", PlayerDatabase.CollectedArtwork253);
		SettingPlayerDataForm.AddField("CollectedArtwork254", PlayerDatabase.CollectedArtwork254);
		SettingPlayerDataForm.AddField("CollectedArtwork255", PlayerDatabase.CollectedArtwork255);
		SettingPlayerDataForm.AddField("CollectedArtwork256", PlayerDatabase.CollectedArtwork256);
		SettingPlayerDataForm.AddField("CollectedArtwork257", PlayerDatabase.CollectedArtwork257);
		SettingPlayerDataForm.AddField("CollectedArtwork258", PlayerDatabase.CollectedArtwork258);
		SettingPlayerDataForm.AddField("CollectedArtwork259", PlayerDatabase.CollectedArtwork259);
		SettingPlayerDataForm.AddField("CollectedArtwork260", PlayerDatabase.CollectedArtwork260);
		SettingPlayerDataForm.AddField("CollectedArtwork261", PlayerDatabase.CollectedArtwork261);
		SettingPlayerDataForm.AddField("CollectedArtwork262", PlayerDatabase.CollectedArtwork262);
		SettingPlayerDataForm.AddField("CollectedArtwork263", PlayerDatabase.CollectedArtwork263);
		SettingPlayerDataForm.AddField("CollectedArtwork264", PlayerDatabase.CollectedArtwork264);
		SettingPlayerDataForm.AddField("CollectedArtwork265", PlayerDatabase.CollectedArtwork265);
		SettingPlayerDataForm.AddField("CollectedArtwork266", PlayerDatabase.CollectedArtwork266);
		SettingPlayerDataForm.AddField("CollectedArtwork267", PlayerDatabase.CollectedArtwork267);
		SettingPlayerDataForm.AddField("CollectedArtwork268", PlayerDatabase.CollectedArtwork268);
		SettingPlayerDataForm.AddField("CollectedArtwork269", PlayerDatabase.CollectedArtwork269);
		SettingPlayerDataForm.AddField("CollectedArtwork270", PlayerDatabase.CollectedArtwork270);
		SettingPlayerDataForm.AddField("CollectedArtwork271", PlayerDatabase.CollectedArtwork271);
		SettingPlayerDataForm.AddField("CollectedArtwork272", PlayerDatabase.CollectedArtwork272);
		SettingPlayerDataForm.AddField("CollectedArtwork273", PlayerDatabase.CollectedArtwork273);
		SettingPlayerDataForm.AddField("CollectedArtwork274", PlayerDatabase.CollectedArtwork274);
		SettingPlayerDataForm.AddField("CollectedArtwork275", PlayerDatabase.CollectedArtwork275);
		SettingPlayerDataForm.AddField("CollectedArtwork276", PlayerDatabase.CollectedArtwork276);
		SettingPlayerDataForm.AddField("CollectedArtwork277", PlayerDatabase.CollectedArtwork277);
		SettingPlayerDataForm.AddField("CollectedArtwork278", PlayerDatabase.CollectedArtwork278);
		SettingPlayerDataForm.AddField("CollectedArtwork279", PlayerDatabase.CollectedArtwork279);
		SettingPlayerDataForm.AddField("CollectedArtwork280", PlayerDatabase.CollectedArtwork280);
		SettingPlayerDataForm.AddField("CollectedArtwork281", PlayerDatabase.CollectedArtwork281);
		SettingPlayerDataForm.AddField("CollectedArtwork282", PlayerDatabase.CollectedArtwork282);
		SettingPlayerDataForm.AddField("CollectedArtwork283", PlayerDatabase.CollectedArtwork283);
		SettingPlayerDataForm.AddField("CollectedArtwork284", PlayerDatabase.CollectedArtwork284);
		SettingPlayerDataForm.AddField("CollectedArtwork285", PlayerDatabase.CollectedArtwork285);
		SettingPlayerDataForm.AddField("CollectedArtwork286", PlayerDatabase.CollectedArtwork286);
		SettingPlayerDataForm.AddField("CollectedArtwork287", PlayerDatabase.CollectedArtwork287);
		SettingPlayerDataForm.AddField("CollectedArtwork288", PlayerDatabase.CollectedArtwork288);
		SettingPlayerDataForm.AddField("CollectedArtwork289", PlayerDatabase.CollectedArtwork289);
		SettingPlayerDataForm.AddField("CollectedArtwork290", PlayerDatabase.CollectedArtwork290);
		SettingPlayerDataForm.AddField("CollectedArtwork291", PlayerDatabase.CollectedArtwork291);
		SettingPlayerDataForm.AddField("CollectedArtwork292", PlayerDatabase.CollectedArtwork292);
		SettingPlayerDataForm.AddField("CollectedArtwork293", PlayerDatabase.CollectedArtwork293);
		SettingPlayerDataForm.AddField("CollectedArtwork294", PlayerDatabase.CollectedArtwork294);
		SettingPlayerDataForm.AddField("CollectedArtwork295", PlayerDatabase.CollectedArtwork295);
		SettingPlayerDataForm.AddField("CollectedArtwork296", PlayerDatabase.CollectedArtwork296);
		SettingPlayerDataForm.AddField("CollectedArtwork297", PlayerDatabase.CollectedArtwork297);
		SettingPlayerDataForm.AddField("CollectedArtwork298", PlayerDatabase.CollectedArtwork298);
		SettingPlayerDataForm.AddField("CollectedArtwork299", PlayerDatabase.CollectedArtwork299);
		SettingPlayerDataForm.AddField("CollectedArtwork300", PlayerDatabase.CollectedArtwork300);
		SettingPlayerDataForm.AddField("CollectedArtwork301", PlayerDatabase.CollectedArtwork301);
		SettingPlayerDataForm.AddField("CollectedArtwork302", PlayerDatabase.CollectedArtwork302);
		SettingPlayerDataForm.AddField("CollectedArtwork303", PlayerDatabase.CollectedArtwork303);
		SettingPlayerDataForm.AddField("CollectedArtwork304", PlayerDatabase.CollectedArtwork304);
		SettingPlayerDataForm.AddField("CollectedArtwork305", PlayerDatabase.CollectedArtwork305);
		SettingPlayerDataForm.AddField("CollectedArtwork306", PlayerDatabase.CollectedArtwork306);
		SettingPlayerDataForm.AddField("CollectedArtwork307", PlayerDatabase.CollectedArtwork307);
		SettingPlayerDataForm.AddField("CollectedArtwork308", PlayerDatabase.CollectedArtwork308);
		SettingPlayerDataForm.AddField("CollectedArtwork309", PlayerDatabase.CollectedArtwork309);
		SettingPlayerDataForm.AddField("CollectedArtwork310", PlayerDatabase.CollectedArtwork310);
		SettingPlayerDataForm.AddField("CollectedArtwork311", PlayerDatabase.CollectedArtwork311);
		SettingPlayerDataForm.AddField("CollectedArtwork312", PlayerDatabase.CollectedArtwork312);
		SettingPlayerDataForm.AddField("CollectedArtwork313", PlayerDatabase.CollectedArtwork313);
		SettingPlayerDataForm.AddField("CollectedArtwork314", PlayerDatabase.CollectedArtwork314);
		SettingPlayerDataForm.AddField("CollectedArtwork315", PlayerDatabase.CollectedArtwork315);
		SettingPlayerDataForm.AddField("CollectedArtwork316", PlayerDatabase.CollectedArtwork316);
		SettingPlayerDataForm.AddField("CollectedArtwork317", PlayerDatabase.CollectedArtwork317);
		SettingPlayerDataForm.AddField("CollectedArtwork318", PlayerDatabase.CollectedArtwork318);
		SettingPlayerDataForm.AddField("CollectedArtwork319", PlayerDatabase.CollectedArtwork319);
		SettingPlayerDataForm.AddField("CollectedArtwork320", PlayerDatabase.CollectedArtwork320);
		SettingPlayerDataForm.AddField("CollectedArtwork321", PlayerDatabase.CollectedArtwork321);
		SettingPlayerDataForm.AddField("CollectedArtwork322", PlayerDatabase.CollectedArtwork322);
		SettingPlayerDataForm.AddField("CollectedArtwork323", PlayerDatabase.CollectedArtwork323);
		SettingPlayerDataForm.AddField("CollectedArtwork324", PlayerDatabase.CollectedArtwork324);
		SettingPlayerDataForm.AddField("CollectedArtwork325", PlayerDatabase.CollectedArtwork325);
		SettingPlayerDataForm.AddField("CollectedArtwork326", PlayerDatabase.CollectedArtwork326);
		SettingPlayerDataForm.AddField("CollectedArtwork327", PlayerDatabase.CollectedArtwork327);
		SettingPlayerDataForm.AddField("CollectedArtwork328", PlayerDatabase.CollectedArtwork328);
		SettingPlayerDataForm.AddField("CollectedArtwork329", PlayerDatabase.CollectedArtwork329);
		SettingPlayerDataForm.AddField("CollectedArtwork330", PlayerDatabase.CollectedArtwork330);
		SettingPlayerDataForm.AddField("CollectedArtwork331", PlayerDatabase.CollectedArtwork331);
		SettingPlayerDataForm.AddField("CollectedArtwork332", PlayerDatabase.CollectedArtwork332);
		SettingPlayerDataForm.AddField("CollectedArtwork333", PlayerDatabase.CollectedArtwork333);
		SettingPlayerDataForm.AddField("CollectedArtwork334", PlayerDatabase.CollectedArtwork334);
		SettingPlayerDataForm.AddField("CollectedArtwork335", PlayerDatabase.CollectedArtwork335);
		SettingPlayerDataForm.AddField("CollectedArtwork336", PlayerDatabase.CollectedArtwork336);
		SettingPlayerDataForm.AddField("CollectedArtwork337", PlayerDatabase.CollectedArtwork337);
		SettingPlayerDataForm.AddField("CollectedArtwork338", PlayerDatabase.CollectedArtwork338);
		SettingPlayerDataForm.AddField("CollectedArtwork339", PlayerDatabase.CollectedArtwork339);
		SettingPlayerDataForm.AddField("CollectedArtwork340", PlayerDatabase.CollectedArtwork340);
		SettingPlayerDataForm.AddField("CollectedArtwork341", PlayerDatabase.CollectedArtwork341);
		SettingPlayerDataForm.AddField("CollectedArtwork342", PlayerDatabase.CollectedArtwork342);
		SettingPlayerDataForm.AddField("CollectedArtwork343", PlayerDatabase.CollectedArtwork343);
		SettingPlayerDataForm.AddField("CollectedArtwork344", PlayerDatabase.CollectedArtwork344);
		SettingPlayerDataForm.AddField("CollectedArtwork345", PlayerDatabase.CollectedArtwork345);
		SettingPlayerDataForm.AddField("CollectedArtwork346", PlayerDatabase.CollectedArtwork346);
		SettingPlayerDataForm.AddField("CollectedArtwork347", PlayerDatabase.CollectedArtwork347);
		SettingPlayerDataForm.AddField("CollectedArtwork348", PlayerDatabase.CollectedArtwork348);
		SettingPlayerDataForm.AddField("CollectedArtwork349", PlayerDatabase.CollectedArtwork349);
		SettingPlayerDataForm.AddField("CollectedArtwork350", PlayerDatabase.CollectedArtwork350);
		SettingPlayerDataForm.AddField("CollectedArtwork351", PlayerDatabase.CollectedArtwork351);
		SettingPlayerDataForm.AddField("CollectedArtwork352", PlayerDatabase.CollectedArtwork352);
		SettingPlayerDataForm.AddField("CollectedArtwork353", PlayerDatabase.CollectedArtwork353);
		SettingPlayerDataForm.AddField("CollectedArtwork354", PlayerDatabase.CollectedArtwork354);
		SettingPlayerDataForm.AddField("CollectedArtwork355", PlayerDatabase.CollectedArtwork355);
		SettingPlayerDataForm.AddField("CollectedArtwork356", PlayerDatabase.CollectedArtwork356);
		SettingPlayerDataForm.AddField("CollectedArtwork357", PlayerDatabase.CollectedArtwork357);
		SettingPlayerDataForm.AddField("CollectedArtwork358", PlayerDatabase.CollectedArtwork358);
		SettingPlayerDataForm.AddField("CollectedArtwork359", PlayerDatabase.CollectedArtwork359);
		SettingPlayerDataForm.AddField("CollectedArtwork360", PlayerDatabase.CollectedArtwork360);
		SettingPlayerDataForm.AddField("CollectedArtwork361", PlayerDatabase.CollectedArtwork361);
		SettingPlayerDataForm.AddField("CollectedArtwork362", PlayerDatabase.CollectedArtwork362);
		SettingPlayerDataForm.AddField("CollectedArtwork363", PlayerDatabase.CollectedArtwork363);
		SettingPlayerDataForm.AddField("CollectedArtwork364", PlayerDatabase.CollectedArtwork364);
		SettingPlayerDataForm.AddField("CollectedArtwork365", PlayerDatabase.CollectedArtwork365);
		SettingPlayerDataForm.AddField("CollectedArtwork366", PlayerDatabase.CollectedArtwork366);
		SettingPlayerDataForm.AddField("CollectedArtwork367", PlayerDatabase.CollectedArtwork367);
		SettingPlayerDataForm.AddField("CollectedArtwork368", PlayerDatabase.CollectedArtwork368);
		SettingPlayerDataForm.AddField("CollectedArtwork369", PlayerDatabase.CollectedArtwork369);
		SettingPlayerDataForm.AddField("CollectedArtwork370", PlayerDatabase.CollectedArtwork370);
		SettingPlayerDataForm.AddField("CollectedArtwork371", PlayerDatabase.CollectedArtwork371);
		SettingPlayerDataForm.AddField("CollectedArtwork372", PlayerDatabase.CollectedArtwork372);
		SettingPlayerDataForm.AddField("CollectedArtwork373", PlayerDatabase.CollectedArtwork373);
		SettingPlayerDataForm.AddField("CollectedArtwork374", PlayerDatabase.CollectedArtwork374);
		SettingPlayerDataForm.AddField("CollectedArtwork375", PlayerDatabase.CollectedArtwork375);
		SettingPlayerDataForm.AddField("CollectedArtwork376", PlayerDatabase.CollectedArtwork376);
		SettingPlayerDataForm.AddField("CollectedArtwork377", PlayerDatabase.CollectedArtwork377);
		SettingPlayerDataForm.AddField("CollectedArtwork378", PlayerDatabase.CollectedArtwork378);
		SettingPlayerDataForm.AddField("CollectedArtwork379", PlayerDatabase.CollectedArtwork379);
		SettingPlayerDataForm.AddField("CollectedArtwork380", PlayerDatabase.CollectedArtwork380);
		SettingPlayerDataForm.AddField("CollectedArtwork381", PlayerDatabase.CollectedArtwork381);
		SettingPlayerDataForm.AddField("CollectedArtwork382", PlayerDatabase.CollectedArtwork382);
		SettingPlayerDataForm.AddField("CollectedArtwork383", PlayerDatabase.CollectedArtwork383);
		SettingPlayerDataForm.AddField("CollectedArtwork384", PlayerDatabase.CollectedArtwork384);
		SettingPlayerDataForm.AddField("CollectedArtwork385", PlayerDatabase.CollectedArtwork385);
		SettingPlayerDataForm.AddField("CollectedArtwork386", PlayerDatabase.CollectedArtwork386);
		SettingPlayerDataForm.AddField("CollectedArtwork387", PlayerDatabase.CollectedArtwork387);
		SettingPlayerDataForm.AddField("CollectedArtwork388", PlayerDatabase.CollectedArtwork388);
		SettingPlayerDataForm.AddField("CollectedArtwork389", PlayerDatabase.CollectedArtwork389);
		SettingPlayerDataForm.AddField("CollectedArtwork390", PlayerDatabase.CollectedArtwork390);
		SettingPlayerDataForm.AddField("CollectedArtwork391", PlayerDatabase.CollectedArtwork391);
		SettingPlayerDataForm.AddField("CollectedArtwork392", PlayerDatabase.CollectedArtwork392);
		SettingPlayerDataForm.AddField("CollectedArtwork393", PlayerDatabase.CollectedArtwork393);
		SettingPlayerDataForm.AddField("CollectedArtwork394", PlayerDatabase.CollectedArtwork394);
		SettingPlayerDataForm.AddField("CollectedArtwork395", PlayerDatabase.CollectedArtwork395);
		SettingPlayerDataForm.AddField("CollectedArtwork396", PlayerDatabase.CollectedArtwork396);
		SettingPlayerDataForm.AddField("CollectedArtwork397", PlayerDatabase.CollectedArtwork397);
		SettingPlayerDataForm.AddField("CollectedArtwork398", PlayerDatabase.CollectedArtwork398);
		SettingPlayerDataForm.AddField("CollectedArtwork399", PlayerDatabase.CollectedArtwork399);
		SettingPlayerDataForm.AddField("CollectedArtwork400", PlayerDatabase.CollectedArtwork400);
		SettingPlayerDataForm.AddField("CollectedArtwork401", PlayerDatabase.CollectedArtwork401);
		SettingPlayerDataForm.AddField("CollectedArtwork402", PlayerDatabase.CollectedArtwork402);
		SettingPlayerDataForm.AddField("CollectedArtwork403", PlayerDatabase.CollectedArtwork403);
		SettingPlayerDataForm.AddField("CollectedArtwork404", PlayerDatabase.CollectedArtwork404);
		SettingPlayerDataForm.AddField("CollectedArtwork405", PlayerDatabase.CollectedArtwork405);
		SettingPlayerDataForm.AddField("CollectedArtwork406", PlayerDatabase.CollectedArtwork406);
		SettingPlayerDataForm.AddField("CollectedArtwork407", PlayerDatabase.CollectedArtwork407);
		SettingPlayerDataForm.AddField("CollectedArtwork408", PlayerDatabase.CollectedArtwork408);
		SettingPlayerDataForm.AddField("CollectedArtwork409", PlayerDatabase.CollectedArtwork409);
		SettingPlayerDataForm.AddField("CollectedArtwork410", PlayerDatabase.CollectedArtwork410);
		SettingPlayerDataForm.AddField("CollectedArtwork411", PlayerDatabase.CollectedArtwork411);
		SettingPlayerDataForm.AddField("CollectedArtwork412", PlayerDatabase.CollectedArtwork412);
		SettingPlayerDataForm.AddField("CollectedArtwork413", PlayerDatabase.CollectedArtwork413);
		SettingPlayerDataForm.AddField("CollectedArtwork414", PlayerDatabase.CollectedArtwork414);
		SettingPlayerDataForm.AddField("CollectedArtwork415", PlayerDatabase.CollectedArtwork415);
		SettingPlayerDataForm.AddField("CollectedArtwork416", PlayerDatabase.CollectedArtwork416);
		SettingPlayerDataForm.AddField("CollectedArtwork417", PlayerDatabase.CollectedArtwork417);
		SettingPlayerDataForm.AddField("CollectedArtwork418", PlayerDatabase.CollectedArtwork418);
		SettingPlayerDataForm.AddField("CollectedArtwork419", PlayerDatabase.CollectedArtwork419);
		SettingPlayerDataForm.AddField("CollectedArtwork420", PlayerDatabase.CollectedArtwork420);
		SettingPlayerDataForm.AddField("CollectedArtwork421", PlayerDatabase.CollectedArtwork421);
		SettingPlayerDataForm.AddField("CollectedArtwork422", PlayerDatabase.CollectedArtwork422);
		SettingPlayerDataForm.AddField("CollectedArtwork423", PlayerDatabase.CollectedArtwork423);
		SettingPlayerDataForm.AddField("CollectedArtwork424", PlayerDatabase.CollectedArtwork424);
		SettingPlayerDataForm.AddField("CollectedArtwork425", PlayerDatabase.CollectedArtwork425);
		SettingPlayerDataForm.AddField("CollectedArtwork426", PlayerDatabase.CollectedArtwork426);
		SettingPlayerDataForm.AddField("CollectedArtwork427", PlayerDatabase.CollectedArtwork427);
		SettingPlayerDataForm.AddField("CollectedArtwork428", PlayerDatabase.CollectedArtwork428);
		SettingPlayerDataForm.AddField("CollectedArtwork429", PlayerDatabase.CollectedArtwork429);
		SettingPlayerDataForm.AddField("CollectedArtwork430", PlayerDatabase.CollectedArtwork430);
		SettingPlayerDataForm.AddField("CollectedArtwork431", PlayerDatabase.CollectedArtwork431);
		SettingPlayerDataForm.AddField("CollectedArtwork432", PlayerDatabase.CollectedArtwork432);
		SettingPlayerDataForm.AddField("CollectedArtwork433", PlayerDatabase.CollectedArtwork433);
		SettingPlayerDataForm.AddField("CollectedArtwork434", PlayerDatabase.CollectedArtwork434);
		SettingPlayerDataForm.AddField("CollectedArtwork435", PlayerDatabase.CollectedArtwork435);
		SettingPlayerDataForm.AddField("CollectedArtwork436", PlayerDatabase.CollectedArtwork436);
		SettingPlayerDataForm.AddField("CollectedArtwork437", PlayerDatabase.CollectedArtwork437);
		SettingPlayerDataForm.AddField("CollectedArtwork438", PlayerDatabase.CollectedArtwork438);
		SettingPlayerDataForm.AddField("CollectedArtwork439", PlayerDatabase.CollectedArtwork439);
		SettingPlayerDataForm.AddField("CollectedArtwork440", PlayerDatabase.CollectedArtwork440);
		SettingPlayerDataForm.AddField("CollectedArtist001", PlayerDatabase.CollectedArtist001);
		SettingPlayerDataForm.AddField("CollectedArtist002", PlayerDatabase.CollectedArtist002);
		SettingPlayerDataForm.AddField("CollectedArtist003", PlayerDatabase.CollectedArtist003);
		SettingPlayerDataForm.AddField("CollectedArtist004", PlayerDatabase.CollectedArtist004);
		SettingPlayerDataForm.AddField("CollectedArtist005", PlayerDatabase.CollectedArtist005);
		SettingPlayerDataForm.AddField("CollectedArtist006", PlayerDatabase.CollectedArtist006);
		SettingPlayerDataForm.AddField("CollectedArtist007", PlayerDatabase.CollectedArtist007);
		SettingPlayerDataForm.AddField("CollectedArtist008", PlayerDatabase.CollectedArtist008);
		SettingPlayerDataForm.AddField("CollectedArtist009", PlayerDatabase.CollectedArtist009);
		SettingPlayerDataForm.AddField("CollectedArtist010", PlayerDatabase.CollectedArtist010);
		SettingPlayerDataForm.AddField("CollectedArtist011", PlayerDatabase.CollectedArtist011);
		SettingPlayerDataForm.AddField("CollectedArtist012", PlayerDatabase.CollectedArtist012);
		SettingPlayerDataForm.AddField("CollectedArtist013", PlayerDatabase.CollectedArtist013);
		SettingPlayerDataForm.AddField("CollectedArtist014", PlayerDatabase.CollectedArtist014);
		SettingPlayerDataForm.AddField("CollectedArtist015", PlayerDatabase.CollectedArtist015);
		SettingPlayerDataForm.AddField("CollectedArtist016", PlayerDatabase.CollectedArtist016);
		SettingPlayerDataForm.AddField("CollectedArtist017", PlayerDatabase.CollectedArtist017);
		SettingPlayerDataForm.AddField("CollectedArtist018", PlayerDatabase.CollectedArtist018);
		SettingPlayerDataForm.AddField("CollectedArtist019", PlayerDatabase.CollectedArtist019);
		SettingPlayerDataForm.AddField("CollectedArtist020", PlayerDatabase.CollectedArtist020);
		SettingPlayerDataForm.AddField("CollectedArtist021", PlayerDatabase.CollectedArtist021);
		SettingPlayerDataForm.AddField("CollectedArtist022", PlayerDatabase.CollectedArtist022);
		SettingPlayerDataForm.AddField("CollectedArtist023", PlayerDatabase.CollectedArtist023);
		SettingPlayerDataForm.AddField("CollectedArtist024", PlayerDatabase.CollectedArtist024);
		SettingPlayerDataForm.AddField("CollectedArtist025", PlayerDatabase.CollectedArtist025);
		SettingPlayerDataForm.AddField("CollectedArtist026", PlayerDatabase.CollectedArtist026);
		SettingPlayerDataForm.AddField("CollectedArtist027", PlayerDatabase.CollectedArtist027);
		SettingPlayerDataForm.AddField("CollectedArtist028", PlayerDatabase.CollectedArtist028);
		SettingPlayerDataForm.AddField("CollectedArtist029", PlayerDatabase.CollectedArtist029);
		SettingPlayerDataForm.AddField("CollectedArtist030", PlayerDatabase.CollectedArtist030);
		SettingPlayerDataForm.AddField("CollectedArtist031", PlayerDatabase.CollectedArtist031);
		SettingPlayerDataForm.AddField("CollectedArtist032", PlayerDatabase.CollectedArtist032);
		SettingPlayerDataForm.AddField("CollectedArtist033", PlayerDatabase.CollectedArtist033);
		SettingPlayerDataForm.AddField("CollectedArtist034", PlayerDatabase.CollectedArtist034);
		SettingPlayerDataForm.AddField("CollectedArtist035", PlayerDatabase.CollectedArtist035);
		SettingPlayerDataForm.AddField("CollectedArtist036", PlayerDatabase.CollectedArtist036);
		SettingPlayerDataForm.AddField("CollectedArtist037", PlayerDatabase.CollectedArtist037);
		SettingPlayerDataForm.AddField("CollectedArtist038", PlayerDatabase.CollectedArtist038);
		SettingPlayerDataForm.AddField("CollectedArtist039", PlayerDatabase.CollectedArtist039);
		SettingPlayerDataForm.AddField("CollectedArtist040", PlayerDatabase.CollectedArtist040);
		SettingPlayerDataForm.AddField("CollectedArtist041", PlayerDatabase.CollectedArtist041);
		SettingPlayerDataForm.AddField("CollectedArtist042", PlayerDatabase.CollectedArtist042);
		SettingPlayerDataForm.AddField("CollectedArtist043", PlayerDatabase.CollectedArtist043);
		SettingPlayerDataForm.AddField("CollectedArtist044", PlayerDatabase.CollectedArtist044);
		SettingPlayerDataForm.AddField("CollectedPatron001", PlayerDatabase.CollectedPatron001);
		SettingPlayerDataForm.AddField("CollectedPatron002", PlayerDatabase.CollectedPatron002);
		SettingPlayerDataForm.AddField("CollectedPatron003", PlayerDatabase.CollectedPatron003);
		SettingPlayerDataForm.AddField("CollectedPatron004", PlayerDatabase.CollectedPatron004);
		SettingPlayerDataForm.AddField("CollectedPatron005", PlayerDatabase.CollectedPatron005);
		SettingPlayerDataForm.AddField("CollectedPatron006", PlayerDatabase.CollectedPatron006);
		SettingPlayerDataForm.AddField("CollectedPatron007", PlayerDatabase.CollectedPatron007);
		SettingPlayerDataForm.AddField("CollectedPatron008", PlayerDatabase.CollectedPatron008);
		SettingPlayerDataForm.AddField("CollectedPatron009", PlayerDatabase.CollectedPatron009);
		SettingPlayerDataForm.AddField("CollectedPatron010", PlayerDatabase.CollectedPatron010);
		SettingPlayerDataForm.AddField("CollectedPatron011", PlayerDatabase.CollectedPatron011);
		SettingPlayerDataForm.AddField("CollectedPatron012", PlayerDatabase.CollectedPatron012);
		SettingPlayerDataForm.AddField("CollectedPatron013", PlayerDatabase.CollectedPatron013);
		SettingPlayerDataForm.AddField("CollectedPatron014", PlayerDatabase.CollectedPatron014);
		SettingPlayerDataForm.AddField("CollectedPatron015", PlayerDatabase.CollectedPatron015);
		SettingPlayerDataForm.AddField("CollectedPatron016", PlayerDatabase.CollectedPatron016);
		SettingPlayerDataForm.AddField("CollectedPaint001", PlayerDatabase.CollectedPaint001);
		SettingPlayerDataForm.AddField("CollectedPaint002", PlayerDatabase.CollectedPaint002);
		SettingPlayerDataForm.AddField("CollectedPaint003", PlayerDatabase.CollectedPaint003);
		SettingPlayerDataForm.AddField("CollectedPaint004", PlayerDatabase.CollectedPaint004);
		SettingPlayerDataForm.AddField("CollectedPaint005", PlayerDatabase.CollectedPaint005);
		SettingPlayerDataForm.AddField("CollectedPaint006", PlayerDatabase.CollectedPaint006);
		SettingPlayerDataForm.AddField("CollectedPaint007", PlayerDatabase.CollectedPaint007);
		SettingPlayerDataForm.AddField("CollectedPaint008", PlayerDatabase.CollectedPaint008);
		SettingPlayerDataForm.AddField("CollectedPaint009", PlayerDatabase.CollectedPaint009);
		SettingPlayerDataForm.AddField("CollectedPaint010", PlayerDatabase.CollectedPaint010);
		SettingPlayerDataForm.AddField("CollectedPaint011", PlayerDatabase.CollectedPaint011);
		SettingPlayerDataForm.AddField("CollectedPaint012", PlayerDatabase.CollectedPaint012);
		SettingPlayerDataForm.AddField("CollectedPaint013", PlayerDatabase.CollectedPaint013);
		SettingPlayerDataForm.AddField("CollectedPaint014", PlayerDatabase.CollectedPaint014);
		SettingPlayerDataForm.AddField("CollectedPaint015", PlayerDatabase.CollectedPaint015);
		SettingPlayerDataForm.AddField("CollectedPaint016", PlayerDatabase.CollectedPaint016);
		SettingPlayerDataForm.AddField("CollectedPaint017", PlayerDatabase.CollectedPaint017);
		SettingPlayerDataForm.AddField("CollectedPaint018", PlayerDatabase.CollectedPaint018);
		SettingPlayerDataForm.AddField("CollectedPaint019", PlayerDatabase.CollectedPaint019);
		SettingPlayerDataForm.AddField("CollectedPaint020", PlayerDatabase.CollectedPaint020);
		SettingPlayerDataForm.AddField("CollectedPaint021", PlayerDatabase.CollectedPaint021);
		SettingPlayerDataForm.AddField("CollectedPaint022", PlayerDatabase.CollectedPaint022);
		SettingPlayerDataForm.AddField("CollectedPaint023", PlayerDatabase.CollectedPaint023);
		SettingPlayerDataForm.AddField("CollectedPaint024", PlayerDatabase.CollectedPaint024);
		SettingPlayerDataForm.AddField("CollectedPaint025", PlayerDatabase.CollectedPaint025);
		SettingPlayerDataForm.AddField("CollectedPaint026", PlayerDatabase.CollectedPaint026);
		SettingPlayerDataForm.AddField("CollectedPaint027", PlayerDatabase.CollectedPaint027);
		SettingPlayerDataForm.AddField("CollectedPaint028", PlayerDatabase.CollectedPaint028);
		SettingPlayerDataForm.AddField("CollectedPaint029", PlayerDatabase.CollectedPaint029);
		SettingPlayerDataForm.AddField("CollectedPaint030", PlayerDatabase.CollectedPaint030);
		SettingPlayerDataForm.AddField("CollectedPaint031", PlayerDatabase.CollectedPaint031);
		SettingPlayerDataForm.AddField("CollectedPaint032", PlayerDatabase.CollectedPaint032);
		SettingPlayerDataForm.AddField("CollectedPaint033", PlayerDatabase.CollectedPaint033);
		SettingPlayerDataForm.AddField("CollectedPaint034", PlayerDatabase.CollectedPaint034);
		SettingPlayerDataForm.AddField("CollectedPaint035", PlayerDatabase.CollectedPaint035);
		SettingPlayerDataForm.AddField("CollectedPaint036", PlayerDatabase.CollectedPaint036);
		SettingPlayerDataForm.AddField("CollectedPaint037", PlayerDatabase.CollectedPaint037);
		SettingPlayerDataForm.AddField("CollectedPaint038", PlayerDatabase.CollectedPaint038);
		SettingPlayerDataForm.AddField("CollectedPaint039", PlayerDatabase.CollectedPaint039);
		SettingPlayerDataForm.AddField("CollectedPaint040", PlayerDatabase.CollectedPaint040);
		SettingPlayerDataForm.AddField("CollectedPaint041", PlayerDatabase.CollectedPaint041);
		SettingPlayerDataForm.AddField("CollectedPaint042", PlayerDatabase.CollectedPaint042);
		SettingPlayerDataForm.AddField("CollectedPaint043", PlayerDatabase.CollectedPaint043);
		SettingPlayerDataForm.AddField("CollectedPaint044", PlayerDatabase.CollectedPaint044);
		SettingPlayerDataForm.AddField("CollectedPaint045", PlayerDatabase.CollectedPaint045);
		SettingPlayerDataForm.AddField("CollectedPaint046", PlayerDatabase.CollectedPaint046);
		SettingPlayerDataForm.AddField("CollectedPaint047", PlayerDatabase.CollectedPaint047);
		SettingPlayerDataForm.AddField("CollectedPaint048", PlayerDatabase.CollectedPaint048);
		SettingPlayerDataForm.AddField("CollectedPaint049", PlayerDatabase.CollectedPaint049);
		SettingPlayerDataForm.AddField("CollectedPaint050", PlayerDatabase.CollectedPaint050);
		SettingPlayerDataForm.AddField("CollectedPaint051", PlayerDatabase.CollectedPaint051);
		SettingPlayerDataForm.AddField("CollectedPaint052", PlayerDatabase.CollectedPaint052);
		SettingPlayerDataForm.AddField("CollectedPaint053", PlayerDatabase.CollectedPaint053);
		SettingPlayerDataForm.AddField("CollectedPaint054", PlayerDatabase.CollectedPaint054);
		SettingPlayerDataForm.AddField("CollectedPaint055", PlayerDatabase.CollectedPaint055);
		SettingPlayerDataForm.AddField("CollectedPaint056", PlayerDatabase.CollectedPaint056);
		SettingPlayerDataForm.AddField("CollectedPaint057", PlayerDatabase.CollectedPaint057);
		SettingPlayerDataForm.AddField("CollectedPaint058", PlayerDatabase.CollectedPaint058);
		SettingPlayerDataForm.AddField("CollectedPaint059", PlayerDatabase.CollectedPaint059);
		SettingPlayerDataForm.AddField("CollectedPaint060", PlayerDatabase.CollectedPaint060);
		SettingPlayerDataForm.AddField("CollectedPaint061", PlayerDatabase.CollectedPaint061);
		SettingPlayerDataForm.AddField("CollectedPaint062", PlayerDatabase.CollectedPaint062);

		using (UnityWebRequest SettingPlayerDataWWW = UnityWebRequest.Post("http://www.theferryman.org/PaintSplatter/PHPSettingPlayerData.php", SettingPlayerDataForm)) {
            yield return SettingPlayerDataWWW.SendWebRequest();
            
            if ((SettingPlayerDataWWW.result == UnityWebRequest.Result.ConnectionError) || (SettingPlayerDataWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(SettingPlayerDataWWW.error);
            }
            
            else {
                if (SettingPlayerDataWWW.downloadHandler.text != "Unable to view database") {
					
                }
                
                else {
					
                }
            }
        }

		yield return new WaitForSeconds(1.0f);
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}