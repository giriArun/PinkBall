using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour {

    public static int DropValue = 0;
    public AudioMixer AudioMix;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void DropDown_Change(int index)
    {
        DropValue = index;
        Debug.Log(index);
    }

    public void SetVolume(float volume)
    {
        Debug.Log(volume);
        AudioMix.SetFloat("Volume", volume);
    }
}
