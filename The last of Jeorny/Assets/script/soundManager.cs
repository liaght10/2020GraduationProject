using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundManager : MonoBehaviour
{

    public Slider volume;
   // 오디오 추가 후 public AudioSource audio;

    private float SVolume = 1f;

    // Start is called before the first frame update
    private void Start()
    {
        SVolume = PlayerPrefs.GetFloat("SVolme", 1f);
        volume.value = SVolume;
      //  audio.volume = volume.value;
    }

    // Update is called once per frame
    void Update()
    {
     //   audio.volume = volume.value;
        SVolume = volume.value;
        PlayerPrefs.SetFloat("SVolme", SVolume);
    }
}
