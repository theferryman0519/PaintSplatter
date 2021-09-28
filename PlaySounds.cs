using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class PlaySounds : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Background Music
	public AudioClip BackgroundMusicClip;
	public AudioSource BackgroundMusic;
		
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static float BackgroundMusicVolume;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Background Music
		BackgroundMusicVolume = BackgroundMusic.volume;
		BackgroundMusicVolume = 2.0f;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- PLAY SOUND & MUSIC FUNCTION ---------------
	public void BackgroundMusicPlay() {
		BackgroundMusic.Play();
		BackgroundMusic.loop = true;
		BackgroundMusicVolume = 2.0f;
	}
	
// --------------- MUTE SOUND & MUSIC FUNCTION ---------------
	public void SoundMusicMute() {
		BackgroundMusicVolume = 0.0f;
	}
	
// --------------- UNMUTE SOUND & MUSIC FUNCTION ---------------
	public void SoundMusicUnmute() {
		BackgroundMusicVolume = 2.0f;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}