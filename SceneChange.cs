using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class SceneChange : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// List of Scenes
    public static string Scene00 = "00FerrymanLogo";
    public static string Scene01 = "01MainLogo";
    public static string Scene02 = "02LogInSignUp";
    public static string Scene03 = "03MainMenu";
    public static string Scene04 = "04TutorialGameplay";
    public static string Scene05 = "05TutorialInfo";
    public static string Scene06 = "06TutorialDeck";
    public static string Scene07 = "07DuelCoinFlip";
    public static string Scene08 = "08DuelSetup";
    public static string Scene09 = "09DuelGameplay";
    public static string Scene10 = "10MultiplayerCoinFlip";
    public static string Scene11 = "11MultiplayerSetup";
    public static string Scene12 = "12MultiplayerGameplay";
    public static string Scene13 = "13YourDeck";
    public static string Scene14 = "14GameStore";
    public static string Scene15 = "15Settings";
	public static string Scene16 = "16ErrorOnLogIn";
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- SCENE CHANGE FUNCTION ---------------
	// Load Scene00 - Ferryman Scene
	public void Scene00Load() {
		SceneManager.LoadScene(Scene00);
	}

	// Load Scene01 - Main Logo Scene
	public void Scene01Load() {
		SceneManager.LoadScene(Scene01);
	}

	// Load Scene02 - Log In Sign Up Scene
	public void Scene02Load() {
		SceneManager.LoadScene(Scene02);
	}

	// Load Scene03 - Main Menu Scene
	public void Scene03Load() {
		SceneManager.LoadScene(Scene03);
	}

	// Load Scene04 - Tutorial Gameplay Scene
	public void Scene04Load() {
		SceneManager.LoadScene(Scene04);
	}

	// Load Scene05 - Tutorial Info Scene
	public void Scene05Load() {
		SceneManager.LoadScene(Scene05);
	}

	// Load Scene06 - Tutorial Deck Scene
	public void Scene06Load() {
		SceneManager.LoadScene(Scene06);
	}

	// Load Scene07 - Duel Coin Flip Scene
	public void Scene07Load() {
		SceneManager.LoadScene(Scene07);
	}

	// Load Scene08 - Duel Setup Scene
	public void Scene08Load() {
		SceneManager.LoadScene(Scene08);
	}

	// Load Scene09 - Duel Gameplay Scene
	public void Scene09Load() {
		SceneManager.LoadScene(Scene09);
	}

	// Load Scene10 - Multiplayer Coin Flip Scene
	public void Scene10Load() {
		SceneManager.LoadScene(Scene10);
	}

	// Load Scene11 - Multiplayer Setup Scene
	public void Scene11Load() {
		SceneManager.LoadScene(Scene11);
	}

	// Load Scene12 - Multiplayer Gameplay Scene
	public void Scene12Load() {
		SceneManager.LoadScene(Scene12);
	}

	// Load Scene13 - Your Deck Scene
	public void Scene13Load() {
		SceneManager.LoadScene(Scene13);
	}

	// Load Scene14 - Game Store Scene
	public void Scene14Load() {
		SceneManager.LoadScene(Scene14);
	}

	// Load Scene15 - Settings Scene
	public void Scene15Load() {
		SceneManager.LoadScene(Scene15);
	}

	// Load Scene16 - Error On Log In Scene
	public void Scene16Load() {
		SceneManager.LoadScene(Scene16);
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}