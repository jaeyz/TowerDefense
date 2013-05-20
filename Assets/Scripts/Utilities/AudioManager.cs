using UnityEngine;
using System.Collections;

public class AudioManager : MonoSingleton<AudioManager> {
	
	public AudioClip mainMenuClip;
	public AudioClip gameSceneClip;
	public AudioClip gameOverClip;
	
	void Awake () {
		DontDestroyOnLoad(gameObject);
	}
	
	void Update() {
	
	}
	
}
