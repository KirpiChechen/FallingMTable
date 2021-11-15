using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LManager : MonoBehaviour
{
    public Image pauseButton;
    public Image volumeButton;

    [Header("PauseButtons")]
    public Sprite kgPauseButton;
    public Sprite ruPauseButton;
    public Sprite engPauseButton;

    [Header("VolumeButtons")]
    public Sprite kgVolumeButton;
    public Sprite ruVolumeButton;
    public Sprite engVolumeButton;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("Language") == "KG")
        {
            pauseButton.sprite = kgPauseButton;
            volumeButton.sprite = kgVolumeButton;
        }

        else if (PlayerPrefs.GetString("Language") == "RU")
        {
            pauseButton.sprite = ruPauseButton;
            volumeButton.sprite = ruVolumeButton;
        }

        else if (PlayerPrefs.GetString("Language") == "ENG")
        {
            pauseButton.sprite = engPauseButton;
            volumeButton.sprite = engVolumeButton;
        }
    }
}
