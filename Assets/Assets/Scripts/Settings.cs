using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof (Slider))]
public class Settings : MonoBehaviour
{
    public AudioMixer mixer;

    [SerializeField] private string volumeName;
    [SerializeField] private Text volumeLabel;

    public Slider slider;

    private void Start()
    {
        slider.GetComponent<Slider>();
        UpdateValueOnChange(slider.value);

        slider.onValueChanged.AddListener(delegate
        {
            UpdateValueOnChange(slider.value);
        });
    }

    public void UpdateValueOnChange(float value)
    {
        if(mixer != null)
        {
            mixer.SetFloat(volumeName, Mathf.Log(value) * 20f);
        }

        if(volumeLabel != null)
        {
            volumeLabel.text = Mathf.Round(value * 100.0f).ToString() + "%";
        }
    }
}
