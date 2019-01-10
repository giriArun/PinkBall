using UnityEngine;
using UnityEngine.Audio;

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
    }

    public void SetVolume(float volume)
    {
        AudioMix.SetFloat("Volume", volume);
    }
}
