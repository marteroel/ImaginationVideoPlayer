using UnityEngine;
using System.Collections;
using RenderHeads.Media.AVProVideo;
using UnityEngine.VR;

public class VideoPlayerAV : MonoBehaviour {

	public MediaPlayer	_mediaPlayer;
	public GameObject loadingImage;
	private bool isPlaying = false;

	// Use this for initialization
	void Start () {
		isPlaying = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("c"))
			InputTracking.Recenter();

		if (Input.GetKeyDown ("m")){
			_mediaPlayer.Control.Stop ();
			loadingImage.SetActive (true);
			Application.LoadLevel(0);
		}

		if (Input.GetKeyDown ("space")) {

			if (!isPlaying) {
				_mediaPlayer.Control.Play ();
				isPlaying = true;
			}


			else if (isPlaying) {
				_mediaPlayer.Control.Pause ();
				isPlaying = false;
			}

		}

		if (_mediaPlayer.Control.IsFinished()) {
				Application.LoadLevel (0);
		}

	}


}
