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

public class Buttons02 : MonoBehaviour {

// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Buttons
	public Button LogInOnButton;
	public Button LogInOffButton;
	public Button SignUpOnButton;
	public Button SignUpOffButton;
	public Button ContinueButton;

	// Input Texts
	public Text UsernameInput;
	public Text FirstNameInput;
	public Text FavArtistInput;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// Log In Error Tracker
	public static int LogInErrorTracker;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene03LoadRun;
	public SceneChange Scene04LoadRun;
	public SceneChange Scene16LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		LogInErrorTracker = 0;

		// LogInOnButton
		Button LogInOnButtonClick = LogInOnButton.GetComponent<Button>();
		LogInOnButtonClick.onClick.AddListener(LogInOnButtonClicking);

		// LogInOffButton
		Button LogInOffButtonClick = LogInOffButton.GetComponent<Button>();
		LogInOffButtonClick.onClick.AddListener(LogInOffButtonClicking);

		// SignUpOnButton
		Button SignUpOnButtonClick = SignUpOnButton.GetComponent<Button>();
		SignUpOnButtonClick.onClick.AddListener(SignUpOnButtonClicking);

		// SignUpOffButton
		Button SignUpOffButtonClick = SignUpOffButton.GetComponent<Button>();
		SignUpOffButtonClick.onClick.AddListener(SignUpOffButtonClicking);

		// ContinueButton
		Button ContinueButtonClick = ContinueButton.GetComponent<Button>();
		ContinueButtonClick.onClick.AddListener(ContinueButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- BUTTON FUNCTIONS ---------------
    public void LogInOnButtonClicking() {
		EnableObjects02.LogInSignUpTracker = 0;
	}

	public void LogInOffButtonClicking() {
		UsernameInput.text = "";
		FirstNameInput.text = "";
		FavArtistInput.text = "";
		EnableObjects02.LogInSignUpTracker = 0;
	}

	public void SignUpOnButtonClicking() {
		EnableObjects02.LogInSignUpTracker = 1;
	}

	public void SignUpOffButtonClicking() {
		UsernameInput.text = "";
		FirstNameInput.text = "";
		FavArtistInput.text = "";
		EnableObjects02.LogInSignUpTracker = 1;
	}

	public void ContinueButtonClicking() {
		if (EnableObjects02.LogInSignUpTracker == 0) {
			PlayerDatabase.PlayerUsername = UsernameInput.text;
			StartCoroutine(LoggingIn());
		}

		else if (EnableObjects02.LogInSignUpTracker == 1) {
			PlayerDatabase.PlayerUsername = UsernameInput.text;
			PlayerDatabase.PlayerFirstName = FirstNameInput.text;
			PlayerDatabase.PlayerFavArtist = FavArtistInput.text;
			StartCoroutine(CheckingUsername());
		}
	}

// --------------- IENUMERATOR FUNCTIONS ---------------
	public IEnumerator LoggingIn() {
		WWWForm LoggingInForm = new WWWForm();
		LoggingInForm.AddField("PlayerUsername", PlayerDatabase.PlayerUsername);

		using (UnityWebRequest LoggingInWWW = UnityWebRequest.Post("http://www.theferryman.org/PaintSplatter/PHPCheckingUsername.php", LoggingInForm)) {
            yield return LoggingInWWW.SendWebRequest();
            
            if ((LoggingInWWW.result == UnityWebRequest.Result.ConnectionError) || (LoggingInWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(LoggingInWWW.error);
            }
            
            else {
                if (LoggingInWWW.downloadHandler.text != "Unable to view database") {
					// Set Player Database
					string jsonArrayString = LoggingInWWW.downloadHandler.text;
					string jsonArrayStringA = jsonArrayString.Replace('"', ' ');
					string jsonArrayStringB = jsonArrayStringA.Replace('{', ' ');
					string jsonArrayStringC = jsonArrayStringB.Replace('}', ' ');
					string jsonArrayStringD = jsonArrayStringC.Replace(']', ' ');
					string jsonArrayStringE = jsonArrayStringD.Replace('[', ' ');
                    string[] jsonArraySplitTwo = jsonArrayStringE.Split(',', ':');

					PlayerDatabase.PlayerFirstName = jsonArraySplitTwo[3].Trim().ToString();
					PlayerDatabase.PlayerFavArtist = jsonArraySplitTwo[5].Trim().ToString();
					PlayerDatabase.PlayerVsCpuWin = jsonArraySplitTwo[7].Trim().ToString();
					PlayerDatabase.PlayerVsCpuLoss = jsonArraySplitTwo[9].Trim().ToString();
					PlayerDatabase.PlayerVsPlayerWin = jsonArraySplitTwo[11].Trim().ToString();
					PlayerDatabase.PlayerVsPlayerLoss = jsonArraySplitTwo[13].Trim().ToString();
					PlayerDatabase.PlayerCoinAmount = jsonArraySplitTwo[15].Trim().ToString();
					PlayerDatabase.PlayerDailyLogin = jsonArraySplitTwo[17].Trim().ToString();
					PlayerDatabase.PlayerCollectLevelReward = jsonArraySplitTwo[19].Trim().ToString();
					
					// Go to Main Menu
					Scene03LoadRun.Scene03Load();
                }
                
                else {
					LogInErrorTracker = 1;
					Scene16LoadRun.Scene16Load();
                }
            }
        }

		yield return new WaitForSeconds(1.0f);
	}

	public IEnumerator CheckingUsername() {
		WWWForm CheckingUsernameForm = new WWWForm();
		CheckingUsernameForm.AddField("PlayerUsername", PlayerDatabase.PlayerUsername);

		using (UnityWebRequest CheckingUsernameWWW = UnityWebRequest.Post("http://www.theferryman.org/PaintSplatter/PHPCheckingUsername.php", CheckingUsernameForm)) {
            yield return CheckingUsernameWWW.SendWebRequest();
            
            if ((CheckingUsernameWWW.result == UnityWebRequest.Result.ConnectionError) || (CheckingUsernameWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(CheckingUsernameWWW.error);
            }
            
            else {
                if (CheckingUsernameWWW.downloadHandler.text != "Unable to view database") {
					LogInErrorTracker = 2;
					Scene16LoadRun.Scene16Load();
                }
                
                else {
					StartCoroutine(SettingPlayer());
                }
            }
        }

		yield return new WaitForSeconds(1.0f);
	}
	
	public IEnumerator SettingPlayer() {
		PlayerDatabase.PlayerDailyLogin = System.DateTime.Now.ToString("MM/dd/yyyy");

		WWWForm SettingPlayerForm = new WWWForm();
		SettingPlayerForm.AddField("PlayerUsername", PlayerDatabase.PlayerUsername);
		SettingPlayerForm.AddField("PlayerFirstName", PlayerDatabase.PlayerFirstName);
		SettingPlayerForm.AddField("PlayerFavArtist", PlayerDatabase.PlayerFavArtist);
		SettingPlayerForm.AddField("PlayerDailyLogin", PlayerDatabase.PlayerDailyLogin);

		using (UnityWebRequest SettingPlayerWWW = UnityWebRequest.Post("http://www.theferryman.org/PaintSplatter/PHPSettingPlayer.php", SettingPlayerForm)) {
            yield return SettingPlayerWWW.SendWebRequest();
            
            if ((SettingPlayerWWW.result == UnityWebRequest.Result.ConnectionError) || (SettingPlayerWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(SettingPlayerWWW.error);
            }
            
            else {
                if (SettingPlayerWWW.downloadHandler.text != "Unable to view database") {
					// Set Database Information
					PlayerDatabase.PlayerVsCpuWin = "0";
					PlayerDatabase.PlayerVsCpuLoss = "0";
					PlayerDatabase.PlayerVsPlayerWin = "0";
					PlayerDatabase.PlayerVsPlayerLoss = "0";
					PlayerDatabase.PlayerCoinAmount = "0";
					PlayerDatabase.PlayerCollectLevelReward = "0";
					PlayerDatabase.CollectedArtwork001 = "0";
					PlayerDatabase.CollectedArtwork002 = "0";
					PlayerDatabase.CollectedArtwork003 = "0";
					PlayerDatabase.CollectedArtwork004 = "0";
					PlayerDatabase.CollectedArtwork005 = "0";
					PlayerDatabase.CollectedArtwork006 = "0";
					PlayerDatabase.CollectedArtwork007 = "0";
					PlayerDatabase.CollectedArtwork008 = "0";
					PlayerDatabase.CollectedArtwork009 = "0";
					PlayerDatabase.CollectedArtwork010 = "0";
					PlayerDatabase.CollectedArtwork011 = "0";
					PlayerDatabase.CollectedArtwork012 = "0";
					PlayerDatabase.CollectedArtwork013 = "0";
					PlayerDatabase.CollectedArtwork014 = "0";
					PlayerDatabase.CollectedArtwork015 = "0";
					PlayerDatabase.CollectedArtwork016 = "0";
					PlayerDatabase.CollectedArtwork017 = "0";
					PlayerDatabase.CollectedArtwork018 = "0";
					PlayerDatabase.CollectedArtwork019 = "0";
					PlayerDatabase.CollectedArtwork020 = "0";
					PlayerDatabase.CollectedArtwork021 = "0";
					PlayerDatabase.CollectedArtwork022 = "0";
					PlayerDatabase.CollectedArtwork023 = "0";
					PlayerDatabase.CollectedArtwork024 = "0";
					PlayerDatabase.CollectedArtwork025 = "0";
					PlayerDatabase.CollectedArtwork026 = "0";
					PlayerDatabase.CollectedArtwork027 = "0";
					PlayerDatabase.CollectedArtwork028 = "0";
					PlayerDatabase.CollectedArtwork029 = "0";
					PlayerDatabase.CollectedArtwork030 = "0";
					PlayerDatabase.CollectedArtwork031 = "0";
					PlayerDatabase.CollectedArtwork032 = "0";
					PlayerDatabase.CollectedArtwork033 = "0";
					PlayerDatabase.CollectedArtwork034 = "0";
					PlayerDatabase.CollectedArtwork035 = "0";
					PlayerDatabase.CollectedArtwork036 = "0";
					PlayerDatabase.CollectedArtwork037 = "0";
					PlayerDatabase.CollectedArtwork038 = "0";
					PlayerDatabase.CollectedArtwork039 = "0";
					PlayerDatabase.CollectedArtwork040 = "0";
					PlayerDatabase.CollectedArtwork041 = "0";
					PlayerDatabase.CollectedArtwork042 = "0";
					PlayerDatabase.CollectedArtwork043 = "0";
					PlayerDatabase.CollectedArtwork044 = "0";
					PlayerDatabase.CollectedArtwork045 = "0";
					PlayerDatabase.CollectedArtwork046 = "0";
					PlayerDatabase.CollectedArtwork047 = "0";
					PlayerDatabase.CollectedArtwork048 = "0";
					PlayerDatabase.CollectedArtwork049 = "0";
					PlayerDatabase.CollectedArtwork050 = "0";
					PlayerDatabase.CollectedArtwork051 = "0";
					PlayerDatabase.CollectedArtwork052 = "0";
					PlayerDatabase.CollectedArtwork053 = "0";
					PlayerDatabase.CollectedArtwork054 = "0";
					PlayerDatabase.CollectedArtwork055 = "0";
					PlayerDatabase.CollectedArtwork056 = "0";
					PlayerDatabase.CollectedArtwork057 = "0";
					PlayerDatabase.CollectedArtwork058 = "0";
					PlayerDatabase.CollectedArtwork059 = "0";
					PlayerDatabase.CollectedArtwork060 = "0";
					PlayerDatabase.CollectedArtwork061 = "0";
					PlayerDatabase.CollectedArtwork062 = "0";
					PlayerDatabase.CollectedArtwork063 = "0";
					PlayerDatabase.CollectedArtwork064 = "0";
					PlayerDatabase.CollectedArtwork065 = "0";
					PlayerDatabase.CollectedArtwork066 = "0";
					PlayerDatabase.CollectedArtwork067 = "0";
					PlayerDatabase.CollectedArtwork068 = "0";
					PlayerDatabase.CollectedArtwork069 = "0";
					PlayerDatabase.CollectedArtwork070 = "0";
					PlayerDatabase.CollectedArtwork071 = "0";
					PlayerDatabase.CollectedArtwork072 = "0";
					PlayerDatabase.CollectedArtwork073 = "0";
					PlayerDatabase.CollectedArtwork074 = "0";
					PlayerDatabase.CollectedArtwork075 = "0";
					PlayerDatabase.CollectedArtwork076 = "0";
					PlayerDatabase.CollectedArtwork077 = "0";
					PlayerDatabase.CollectedArtwork078 = "0";
					PlayerDatabase.CollectedArtwork079 = "0";
					PlayerDatabase.CollectedArtwork080 = "0";
					PlayerDatabase.CollectedArtwork081 = "0";
					PlayerDatabase.CollectedArtwork082 = "0";
					PlayerDatabase.CollectedArtwork083 = "0";
					PlayerDatabase.CollectedArtwork084 = "0";
					PlayerDatabase.CollectedArtwork085 = "0";
					PlayerDatabase.CollectedArtwork086 = "0";
					PlayerDatabase.CollectedArtwork087 = "0";
					PlayerDatabase.CollectedArtwork088 = "0";
					PlayerDatabase.CollectedArtwork089 = "0";
					PlayerDatabase.CollectedArtwork090 = "0";
					PlayerDatabase.CollectedArtwork091 = "0";
					PlayerDatabase.CollectedArtwork092 = "0";
					PlayerDatabase.CollectedArtwork093 = "0";
					PlayerDatabase.CollectedArtwork094 = "0";
					PlayerDatabase.CollectedArtwork095 = "0";
					PlayerDatabase.CollectedArtwork096 = "0";
					PlayerDatabase.CollectedArtwork097 = "0";
					PlayerDatabase.CollectedArtwork098 = "0";
					PlayerDatabase.CollectedArtwork099 = "0";
					PlayerDatabase.CollectedArtwork100 = "0";
					PlayerDatabase.CollectedArtwork101 = "0";
					PlayerDatabase.CollectedArtwork102 = "0";
					PlayerDatabase.CollectedArtwork103 = "0";
					PlayerDatabase.CollectedArtwork104 = "0";
					PlayerDatabase.CollectedArtwork105 = "0";
					PlayerDatabase.CollectedArtwork106 = "0";
					PlayerDatabase.CollectedArtwork107 = "0";
					PlayerDatabase.CollectedArtwork108 = "0";
					PlayerDatabase.CollectedArtwork109 = "0";
					PlayerDatabase.CollectedArtwork110 = "0";
					PlayerDatabase.CollectedArtwork111 = "0";
					PlayerDatabase.CollectedArtwork112 = "0";
					PlayerDatabase.CollectedArtwork113 = "0";
					PlayerDatabase.CollectedArtwork114 = "0";
					PlayerDatabase.CollectedArtwork115 = "0";
					PlayerDatabase.CollectedArtwork116 = "0";
					PlayerDatabase.CollectedArtwork117 = "0";
					PlayerDatabase.CollectedArtwork118 = "0";
					PlayerDatabase.CollectedArtwork119 = "0";
					PlayerDatabase.CollectedArtwork120 = "0";
					PlayerDatabase.CollectedArtwork121 = "0";
					PlayerDatabase.CollectedArtwork122 = "0";
					PlayerDatabase.CollectedArtwork123 = "0";
					PlayerDatabase.CollectedArtwork124 = "0";
					PlayerDatabase.CollectedArtwork125 = "0";
					PlayerDatabase.CollectedArtwork126 = "0";
					PlayerDatabase.CollectedArtwork127 = "0";
					PlayerDatabase.CollectedArtwork128 = "0";
					PlayerDatabase.CollectedArtwork129 = "0";
					PlayerDatabase.CollectedArtwork130 = "0";
					PlayerDatabase.CollectedArtwork131 = "0";
					PlayerDatabase.CollectedArtwork132 = "0";
					PlayerDatabase.CollectedArtwork133 = "0";
					PlayerDatabase.CollectedArtwork134 = "0";
					PlayerDatabase.CollectedArtwork135 = "0";
					PlayerDatabase.CollectedArtwork136 = "0";
					PlayerDatabase.CollectedArtwork137 = "0";
					PlayerDatabase.CollectedArtwork138 = "0";
					PlayerDatabase.CollectedArtwork139 = "0";
					PlayerDatabase.CollectedArtwork140 = "0";
					PlayerDatabase.CollectedArtwork141 = "0";
					PlayerDatabase.CollectedArtwork142 = "0";
					PlayerDatabase.CollectedArtwork143 = "0";
					PlayerDatabase.CollectedArtwork144 = "0";
					PlayerDatabase.CollectedArtwork145 = "0";
					PlayerDatabase.CollectedArtwork146 = "0";
					PlayerDatabase.CollectedArtwork147 = "0";
					PlayerDatabase.CollectedArtwork148 = "0";
					PlayerDatabase.CollectedArtwork149 = "0";
					PlayerDatabase.CollectedArtwork150 = "0";
					PlayerDatabase.CollectedArtwork151 = "0";
					PlayerDatabase.CollectedArtwork152 = "0";
					PlayerDatabase.CollectedArtwork153 = "0";
					PlayerDatabase.CollectedArtwork154 = "0";
					PlayerDatabase.CollectedArtwork155 = "0";
					PlayerDatabase.CollectedArtwork156 = "0";
					PlayerDatabase.CollectedArtwork157 = "0";
					PlayerDatabase.CollectedArtwork158 = "0";
					PlayerDatabase.CollectedArtwork159 = "0";
					PlayerDatabase.CollectedArtwork160 = "0";
					PlayerDatabase.CollectedArtwork161 = "0";
					PlayerDatabase.CollectedArtwork162 = "0";
					PlayerDatabase.CollectedArtwork163 = "0";
					PlayerDatabase.CollectedArtwork164 = "0";
					PlayerDatabase.CollectedArtwork165 = "0";
					PlayerDatabase.CollectedArtwork166 = "0";
					PlayerDatabase.CollectedArtwork167 = "0";
					PlayerDatabase.CollectedArtwork168 = "0";
					PlayerDatabase.CollectedArtwork169 = "0";
					PlayerDatabase.CollectedArtwork170 = "0";
					PlayerDatabase.CollectedArtwork171 = "0";
					PlayerDatabase.CollectedArtwork172 = "0";
					PlayerDatabase.CollectedArtwork173 = "0";
					PlayerDatabase.CollectedArtwork174 = "0";
					PlayerDatabase.CollectedArtwork175 = "0";
					PlayerDatabase.CollectedArtwork176 = "0";
					PlayerDatabase.CollectedArtwork177 = "0";
					PlayerDatabase.CollectedArtwork178 = "0";
					PlayerDatabase.CollectedArtwork179 = "0";
					PlayerDatabase.CollectedArtwork180 = "0";
					PlayerDatabase.CollectedArtwork181 = "0";
					PlayerDatabase.CollectedArtwork182 = "0";
					PlayerDatabase.CollectedArtwork183 = "0";
					PlayerDatabase.CollectedArtwork184 = "0";
					PlayerDatabase.CollectedArtwork185 = "0";
					PlayerDatabase.CollectedArtwork186 = "0";
					PlayerDatabase.CollectedArtwork187 = "0";
					PlayerDatabase.CollectedArtwork188 = "0";
					PlayerDatabase.CollectedArtwork189 = "0";
					PlayerDatabase.CollectedArtwork190 = "0";
					PlayerDatabase.CollectedArtwork191 = "0";
					PlayerDatabase.CollectedArtwork192 = "0";
					PlayerDatabase.CollectedArtwork193 = "0";
					PlayerDatabase.CollectedArtwork194 = "0";
					PlayerDatabase.CollectedArtwork195 = "0";
					PlayerDatabase.CollectedArtwork196 = "0";
					PlayerDatabase.CollectedArtwork197 = "0";
					PlayerDatabase.CollectedArtwork198 = "0";
					PlayerDatabase.CollectedArtwork199 = "0";
					PlayerDatabase.CollectedArtwork200 = "0";
					PlayerDatabase.CollectedArtwork201 = "0";
					PlayerDatabase.CollectedArtwork202 = "0";
					PlayerDatabase.CollectedArtwork203 = "0";
					PlayerDatabase.CollectedArtwork204 = "0";
					PlayerDatabase.CollectedArtwork205 = "0";
					PlayerDatabase.CollectedArtwork206 = "0";
					PlayerDatabase.CollectedArtwork207 = "0";
					PlayerDatabase.CollectedArtwork208 = "0";
					PlayerDatabase.CollectedArtwork209 = "0";
					PlayerDatabase.CollectedArtwork210 = "0";
					PlayerDatabase.CollectedArtwork211 = "0";
					PlayerDatabase.CollectedArtwork212 = "0";
					PlayerDatabase.CollectedArtwork213 = "0";
					PlayerDatabase.CollectedArtwork214 = "0";
					PlayerDatabase.CollectedArtwork215 = "0";
					PlayerDatabase.CollectedArtwork216 = "0";
					PlayerDatabase.CollectedArtwork217 = "0";
					PlayerDatabase.CollectedArtwork218 = "0";
					PlayerDatabase.CollectedArtwork219 = "0";
					PlayerDatabase.CollectedArtwork220 = "0";
					PlayerDatabase.CollectedArtwork221 = "0";
					PlayerDatabase.CollectedArtwork222 = "0";
					PlayerDatabase.CollectedArtwork223 = "0";
					PlayerDatabase.CollectedArtwork224 = "0";
					PlayerDatabase.CollectedArtwork225 = "0";
					PlayerDatabase.CollectedArtwork226 = "0";
					PlayerDatabase.CollectedArtwork227 = "0";
					PlayerDatabase.CollectedArtwork228 = "0";
					PlayerDatabase.CollectedArtwork229 = "0";
					PlayerDatabase.CollectedArtwork230 = "0";
					PlayerDatabase.CollectedArtwork231 = "0";
					PlayerDatabase.CollectedArtwork232 = "0";
					PlayerDatabase.CollectedArtwork233 = "0";
					PlayerDatabase.CollectedArtwork234 = "0";
					PlayerDatabase.CollectedArtwork235 = "0";
					PlayerDatabase.CollectedArtwork236 = "0";
					PlayerDatabase.CollectedArtwork237 = "0";
					PlayerDatabase.CollectedArtwork238 = "0";
					PlayerDatabase.CollectedArtwork239 = "0";
					PlayerDatabase.CollectedArtwork240 = "0";
					PlayerDatabase.CollectedArtwork241 = "0";
					PlayerDatabase.CollectedArtwork242 = "0";
					PlayerDatabase.CollectedArtwork243 = "0";
					PlayerDatabase.CollectedArtwork244 = "0";
					PlayerDatabase.CollectedArtwork245 = "0";
					PlayerDatabase.CollectedArtwork246 = "0";
					PlayerDatabase.CollectedArtwork247 = "0";
					PlayerDatabase.CollectedArtwork248 = "0";
					PlayerDatabase.CollectedArtwork249 = "0";
					PlayerDatabase.CollectedArtwork250 = "0";
					PlayerDatabase.CollectedArtwork251 = "0";
					PlayerDatabase.CollectedArtwork252 = "0";
					PlayerDatabase.CollectedArtwork253 = "0";
					PlayerDatabase.CollectedArtwork254 = "0";
					PlayerDatabase.CollectedArtwork255 = "0";
					PlayerDatabase.CollectedArtwork256 = "0";
					PlayerDatabase.CollectedArtwork257 = "0";
					PlayerDatabase.CollectedArtwork258 = "0";
					PlayerDatabase.CollectedArtwork259 = "0";
					PlayerDatabase.CollectedArtwork260 = "0";
					PlayerDatabase.CollectedArtwork261 = "0";
					PlayerDatabase.CollectedArtwork262 = "0";
					PlayerDatabase.CollectedArtwork263 = "0";
					PlayerDatabase.CollectedArtwork264 = "0";
					PlayerDatabase.CollectedArtwork265 = "0";
					PlayerDatabase.CollectedArtwork266 = "0";
					PlayerDatabase.CollectedArtwork267 = "0";
					PlayerDatabase.CollectedArtwork268 = "0";
					PlayerDatabase.CollectedArtwork269 = "0";
					PlayerDatabase.CollectedArtwork270 = "0";
					PlayerDatabase.CollectedArtwork271 = "0";
					PlayerDatabase.CollectedArtwork272 = "0";
					PlayerDatabase.CollectedArtwork273 = "0";
					PlayerDatabase.CollectedArtwork274 = "0";
					PlayerDatabase.CollectedArtwork275 = "0";
					PlayerDatabase.CollectedArtwork276 = "0";
					PlayerDatabase.CollectedArtwork277 = "0";
					PlayerDatabase.CollectedArtwork278 = "0";
					PlayerDatabase.CollectedArtwork279 = "0";
					PlayerDatabase.CollectedArtwork280 = "0";
					PlayerDatabase.CollectedArtwork281 = "0";
					PlayerDatabase.CollectedArtwork282 = "0";
					PlayerDatabase.CollectedArtwork283 = "0";
					PlayerDatabase.CollectedArtwork284 = "0";
					PlayerDatabase.CollectedArtwork285 = "0";
					PlayerDatabase.CollectedArtwork286 = "0";
					PlayerDatabase.CollectedArtwork287 = "0";
					PlayerDatabase.CollectedArtwork288 = "0";
					PlayerDatabase.CollectedArtwork289 = "0";
					PlayerDatabase.CollectedArtwork290 = "0";
					PlayerDatabase.CollectedArtwork291 = "0";
					PlayerDatabase.CollectedArtwork292 = "0";
					PlayerDatabase.CollectedArtwork293 = "0";
					PlayerDatabase.CollectedArtwork294 = "0";
					PlayerDatabase.CollectedArtwork295 = "0";
					PlayerDatabase.CollectedArtwork296 = "0";
					PlayerDatabase.CollectedArtwork297 = "0";
					PlayerDatabase.CollectedArtwork298 = "0";
					PlayerDatabase.CollectedArtwork299 = "0";
					PlayerDatabase.CollectedArtwork300 = "0";
					PlayerDatabase.CollectedArtwork301 = "0";
					PlayerDatabase.CollectedArtwork302 = "0";
					PlayerDatabase.CollectedArtwork303 = "0";
					PlayerDatabase.CollectedArtwork304 = "0";
					PlayerDatabase.CollectedArtwork305 = "0";
					PlayerDatabase.CollectedArtwork306 = "0";
					PlayerDatabase.CollectedArtwork307 = "0";
					PlayerDatabase.CollectedArtwork308 = "0";
					PlayerDatabase.CollectedArtwork309 = "0";
					PlayerDatabase.CollectedArtwork310 = "0";
					PlayerDatabase.CollectedArtwork311 = "0";
					PlayerDatabase.CollectedArtwork312 = "0";
					PlayerDatabase.CollectedArtwork313 = "0";
					PlayerDatabase.CollectedArtwork314 = "0";
					PlayerDatabase.CollectedArtwork315 = "0";
					PlayerDatabase.CollectedArtwork316 = "0";
					PlayerDatabase.CollectedArtwork317 = "0";
					PlayerDatabase.CollectedArtwork318 = "0";
					PlayerDatabase.CollectedArtwork319 = "0";
					PlayerDatabase.CollectedArtwork320 = "0";
					PlayerDatabase.CollectedArtwork321 = "0";
					PlayerDatabase.CollectedArtwork322 = "0";
					PlayerDatabase.CollectedArtwork323 = "0";
					PlayerDatabase.CollectedArtwork324 = "0";
					PlayerDatabase.CollectedArtwork325 = "0";
					PlayerDatabase.CollectedArtwork326 = "0";
					PlayerDatabase.CollectedArtwork327 = "0";
					PlayerDatabase.CollectedArtwork328 = "0";
					PlayerDatabase.CollectedArtwork329 = "0";
					PlayerDatabase.CollectedArtwork330 = "0";
					PlayerDatabase.CollectedArtwork331 = "0";
					PlayerDatabase.CollectedArtwork332 = "0";
					PlayerDatabase.CollectedArtwork333 = "0";
					PlayerDatabase.CollectedArtwork334 = "0";
					PlayerDatabase.CollectedArtwork335 = "0";
					PlayerDatabase.CollectedArtwork336 = "0";
					PlayerDatabase.CollectedArtwork337 = "0";
					PlayerDatabase.CollectedArtwork338 = "0";
					PlayerDatabase.CollectedArtwork339 = "0";
					PlayerDatabase.CollectedArtwork340 = "0";
					PlayerDatabase.CollectedArtwork341 = "0";
					PlayerDatabase.CollectedArtwork342 = "0";
					PlayerDatabase.CollectedArtwork343 = "0";
					PlayerDatabase.CollectedArtwork344 = "0";
					PlayerDatabase.CollectedArtwork345 = "0";
					PlayerDatabase.CollectedArtwork346 = "0";
					PlayerDatabase.CollectedArtwork347 = "0";
					PlayerDatabase.CollectedArtwork348 = "0";
					PlayerDatabase.CollectedArtwork349 = "0";
					PlayerDatabase.CollectedArtwork350 = "0";
					PlayerDatabase.CollectedArtwork351 = "0";
					PlayerDatabase.CollectedArtwork352 = "0";
					PlayerDatabase.CollectedArtwork353 = "0";
					PlayerDatabase.CollectedArtwork354 = "0";
					PlayerDatabase.CollectedArtwork355 = "0";
					PlayerDatabase.CollectedArtwork356 = "0";
					PlayerDatabase.CollectedArtwork357 = "0";
					PlayerDatabase.CollectedArtwork358 = "0";
					PlayerDatabase.CollectedArtwork359 = "0";
					PlayerDatabase.CollectedArtwork360 = "0";
					PlayerDatabase.CollectedArtwork361 = "0";
					PlayerDatabase.CollectedArtwork362 = "0";
					PlayerDatabase.CollectedArtwork363 = "0";
					PlayerDatabase.CollectedArtwork364 = "0";
					PlayerDatabase.CollectedArtwork365 = "0";
					PlayerDatabase.CollectedArtwork366 = "0";
					PlayerDatabase.CollectedArtwork367 = "0";
					PlayerDatabase.CollectedArtwork368 = "0";
					PlayerDatabase.CollectedArtwork369 = "0";
					PlayerDatabase.CollectedArtwork370 = "0";
					PlayerDatabase.CollectedArtwork371 = "0";
					PlayerDatabase.CollectedArtwork372 = "0";
					PlayerDatabase.CollectedArtwork373 = "0";
					PlayerDatabase.CollectedArtwork374 = "0";
					PlayerDatabase.CollectedArtwork375 = "0";
					PlayerDatabase.CollectedArtwork376 = "0";
					PlayerDatabase.CollectedArtwork377 = "0";
					PlayerDatabase.CollectedArtwork378 = "0";
					PlayerDatabase.CollectedArtwork379 = "0";
					PlayerDatabase.CollectedArtwork380 = "0";
					PlayerDatabase.CollectedArtwork381 = "0";
					PlayerDatabase.CollectedArtwork382 = "0";
					PlayerDatabase.CollectedArtwork383 = "0";
					PlayerDatabase.CollectedArtwork384 = "0";
					PlayerDatabase.CollectedArtwork385 = "0";
					PlayerDatabase.CollectedArtwork386 = "0";
					PlayerDatabase.CollectedArtwork387 = "0";
					PlayerDatabase.CollectedArtwork388 = "0";
					PlayerDatabase.CollectedArtwork389 = "0";
					PlayerDatabase.CollectedArtwork390 = "0";
					PlayerDatabase.CollectedArtwork391 = "0";
					PlayerDatabase.CollectedArtwork392 = "0";
					PlayerDatabase.CollectedArtwork393 = "0";
					PlayerDatabase.CollectedArtwork394 = "0";
					PlayerDatabase.CollectedArtwork395 = "0";
					PlayerDatabase.CollectedArtwork396 = "0";
					PlayerDatabase.CollectedArtwork397 = "0";
					PlayerDatabase.CollectedArtwork398 = "0";
					PlayerDatabase.CollectedArtwork399 = "0";
					PlayerDatabase.CollectedArtwork400 = "0";
					PlayerDatabase.CollectedArtwork401 = "0";
					PlayerDatabase.CollectedArtwork402 = "0";
					PlayerDatabase.CollectedArtwork403 = "0";
					PlayerDatabase.CollectedArtwork404 = "0";
					PlayerDatabase.CollectedArtwork405 = "0";
					PlayerDatabase.CollectedArtwork406 = "0";
					PlayerDatabase.CollectedArtwork407 = "0";
					PlayerDatabase.CollectedArtwork408 = "0";
					PlayerDatabase.CollectedArtwork409 = "0";
					PlayerDatabase.CollectedArtwork410 = "0";
					PlayerDatabase.CollectedArtwork411 = "0";
					PlayerDatabase.CollectedArtwork412 = "0";
					PlayerDatabase.CollectedArtwork413 = "0";
					PlayerDatabase.CollectedArtwork414 = "0";
					PlayerDatabase.CollectedArtwork415 = "0";
					PlayerDatabase.CollectedArtwork416 = "0";
					PlayerDatabase.CollectedArtwork417 = "0";
					PlayerDatabase.CollectedArtwork418 = "0";
					PlayerDatabase.CollectedArtwork419 = "0";
					PlayerDatabase.CollectedArtwork420 = "0";
					PlayerDatabase.CollectedArtwork421 = "0";
					PlayerDatabase.CollectedArtwork422 = "0";
					PlayerDatabase.CollectedArtwork423 = "0";
					PlayerDatabase.CollectedArtwork424 = "0";
					PlayerDatabase.CollectedArtwork425 = "0";
					PlayerDatabase.CollectedArtwork426 = "0";
					PlayerDatabase.CollectedArtwork427 = "0";
					PlayerDatabase.CollectedArtwork428 = "0";
					PlayerDatabase.CollectedArtwork429 = "0";
					PlayerDatabase.CollectedArtwork430 = "0";
					PlayerDatabase.CollectedArtwork431 = "0";
					PlayerDatabase.CollectedArtwork432 = "0";
					PlayerDatabase.CollectedArtwork433 = "0";
					PlayerDatabase.CollectedArtwork434 = "0";
					PlayerDatabase.CollectedArtwork435 = "0";
					PlayerDatabase.CollectedArtwork436 = "0";
					PlayerDatabase.CollectedArtwork437 = "0";
					PlayerDatabase.CollectedArtwork438 = "0";
					PlayerDatabase.CollectedArtwork439 = "0";
					PlayerDatabase.CollectedArtwork440 = "0";
					PlayerDatabase.CollectedArtist001 = "0";
					PlayerDatabase.CollectedArtist002 = "0";
					PlayerDatabase.CollectedArtist003 = "0";
					PlayerDatabase.CollectedArtist004 = "0";
					PlayerDatabase.CollectedArtist005 = "0";
					PlayerDatabase.CollectedArtist006 = "0";
					PlayerDatabase.CollectedArtist007 = "0";
					PlayerDatabase.CollectedArtist008 = "0";
					PlayerDatabase.CollectedArtist009 = "0";
					PlayerDatabase.CollectedArtist010 = "0";
					PlayerDatabase.CollectedArtist011 = "0";
					PlayerDatabase.CollectedArtist012 = "0";
					PlayerDatabase.CollectedArtist013 = "0";
					PlayerDatabase.CollectedArtist014 = "0";
					PlayerDatabase.CollectedArtist015 = "0";
					PlayerDatabase.CollectedArtist016 = "0";
					PlayerDatabase.CollectedArtist017 = "0";
					PlayerDatabase.CollectedArtist018 = "0";
					PlayerDatabase.CollectedArtist019 = "0";
					PlayerDatabase.CollectedArtist020 = "0";
					PlayerDatabase.CollectedArtist021 = "0";
					PlayerDatabase.CollectedArtist022 = "0";
					PlayerDatabase.CollectedArtist023 = "0";
					PlayerDatabase.CollectedArtist024 = "0";
					PlayerDatabase.CollectedArtist025 = "0";
					PlayerDatabase.CollectedArtist026 = "0";
					PlayerDatabase.CollectedArtist027 = "0";
					PlayerDatabase.CollectedArtist028 = "0";
					PlayerDatabase.CollectedArtist029 = "0";
					PlayerDatabase.CollectedArtist030 = "0";
					PlayerDatabase.CollectedArtist031 = "0";
					PlayerDatabase.CollectedArtist032 = "0";
					PlayerDatabase.CollectedArtist033 = "0";
					PlayerDatabase.CollectedArtist034 = "0";
					PlayerDatabase.CollectedArtist035 = "0";
					PlayerDatabase.CollectedArtist036 = "0";
					PlayerDatabase.CollectedArtist037 = "0";
					PlayerDatabase.CollectedArtist038 = "0";
					PlayerDatabase.CollectedArtist039 = "0";
					PlayerDatabase.CollectedArtist040 = "0";
					PlayerDatabase.CollectedArtist041 = "0";
					PlayerDatabase.CollectedArtist042 = "0";
					PlayerDatabase.CollectedArtist043 = "0";
					PlayerDatabase.CollectedArtist044 = "0";
					PlayerDatabase.CollectedPatron001 = "0";
					PlayerDatabase.CollectedPatron002 = "0";
					PlayerDatabase.CollectedPatron003 = "0";
					PlayerDatabase.CollectedPatron004 = "0";
					PlayerDatabase.CollectedPatron005 = "0";
					PlayerDatabase.CollectedPatron006 = "0";
					PlayerDatabase.CollectedPatron007 = "0";
					PlayerDatabase.CollectedPatron008 = "0";
					PlayerDatabase.CollectedPatron009 = "0";
					PlayerDatabase.CollectedPatron010 = "0";
					PlayerDatabase.CollectedPatron011 = "0";
					PlayerDatabase.CollectedPatron012 = "0";
					PlayerDatabase.CollectedPatron013 = "0";
					PlayerDatabase.CollectedPatron014 = "0";
					PlayerDatabase.CollectedPatron015 = "0";
					PlayerDatabase.CollectedPatron016 = "0";
					PlayerDatabase.CollectedPaint001 = "0";
					PlayerDatabase.CollectedPaint002 = "0";
					PlayerDatabase.CollectedPaint003 = "0";
					PlayerDatabase.CollectedPaint004 = "0";
					PlayerDatabase.CollectedPaint005 = "0";
					PlayerDatabase.CollectedPaint006 = "0";
					PlayerDatabase.CollectedPaint007 = "0";
					PlayerDatabase.CollectedPaint008 = "0";
					PlayerDatabase.CollectedPaint009 = "0";
					PlayerDatabase.CollectedPaint010 = "0";
					PlayerDatabase.CollectedPaint011 = "0";
					PlayerDatabase.CollectedPaint012 = "0";
					PlayerDatabase.CollectedPaint013 = "0";
					PlayerDatabase.CollectedPaint014 = "0";
					PlayerDatabase.CollectedPaint015 = "0";
					PlayerDatabase.CollectedPaint016 = "0";
					PlayerDatabase.CollectedPaint017 = "0";
					PlayerDatabase.CollectedPaint018 = "0";
					PlayerDatabase.CollectedPaint019 = "0";
					PlayerDatabase.CollectedPaint020 = "0";
					PlayerDatabase.CollectedPaint021 = "0";
					PlayerDatabase.CollectedPaint022 = "0";
					PlayerDatabase.CollectedPaint023 = "0";
					PlayerDatabase.CollectedPaint024 = "0";
					PlayerDatabase.CollectedPaint025 = "0";
					PlayerDatabase.CollectedPaint026 = "0";
					PlayerDatabase.CollectedPaint027 = "0";
					PlayerDatabase.CollectedPaint028 = "0";
					PlayerDatabase.CollectedPaint029 = "0";
					PlayerDatabase.CollectedPaint030 = "0";
					PlayerDatabase.CollectedPaint031 = "0";
					PlayerDatabase.CollectedPaint032 = "0";
					PlayerDatabase.CollectedPaint033 = "0";
					PlayerDatabase.CollectedPaint034 = "0";
					PlayerDatabase.CollectedPaint035 = "0";
					PlayerDatabase.CollectedPaint036 = "0";
					PlayerDatabase.CollectedPaint037 = "0";
					PlayerDatabase.CollectedPaint038 = "0";
					PlayerDatabase.CollectedPaint039 = "0";
					PlayerDatabase.CollectedPaint040 = "0";
					PlayerDatabase.CollectedPaint041 = "0";
					PlayerDatabase.CollectedPaint042 = "0";
					PlayerDatabase.CollectedPaint043 = "0";
					PlayerDatabase.CollectedPaint044 = "0";
					PlayerDatabase.CollectedPaint045 = "0";
					PlayerDatabase.CollectedPaint046 = "0";
					PlayerDatabase.CollectedPaint047 = "0";
					PlayerDatabase.CollectedPaint048 = "0";
					PlayerDatabase.CollectedPaint049 = "0";
					PlayerDatabase.CollectedPaint050 = "0";
					PlayerDatabase.CollectedPaint051 = "0";
					PlayerDatabase.CollectedPaint052 = "0";
					PlayerDatabase.CollectedPaint053 = "0";
					PlayerDatabase.CollectedPaint054 = "0";
					PlayerDatabase.CollectedPaint055 = "0";
					PlayerDatabase.CollectedPaint056 = "0";
					PlayerDatabase.CollectedPaint057 = "0";
					PlayerDatabase.CollectedPaint058 = "0";
					PlayerDatabase.CollectedPaint059 = "0";
					PlayerDatabase.CollectedPaint060 = "0";
					PlayerDatabase.CollectedPaint061 = "0";
					PlayerDatabase.CollectedPaint062 = "0";

					// Go to Tutorial Scene
					// Scene04LoadRun.Scene04Load();
					// FOR NOW
					Scene03LoadRun.Scene03Load();
                }
                
                else {
					LogInErrorTracker = 3;
					Scene16LoadRun.Scene16Load();
                }
            }
        }

		yield return new WaitForSeconds(1.0f);
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}