using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class SetBGMusic : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
    public static int MusicIsMute;
    public static SetBGMusic Instance {
        get {
            return MusicInstance;
        }
    }
    
    private static SetBGMusic MusicInstance = null;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		MusicIsMute = 1;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		if ((MusicInstance != null) && (MusicInstance != this)) {
            Destroy(this.gameObject);
            return;
        }
        
        else {
            MusicInstance = this;
        }
        
        DontDestroyOnLoad(this.gameObject);
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (MusicIsMute == 0) {
            AudioListener.volume = 0;
        }
        
        if (MusicIsMute == 1) {
            AudioListener.volume = 1;
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}