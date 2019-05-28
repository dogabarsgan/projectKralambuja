using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderScript : MonoBehaviour {

	public Slider VolumeSlider;

  public void AdjustVolume () {

		float masterVolume = VolumeSlider.value;

  	AudioListener.volume = masterVolume;

	}

}
