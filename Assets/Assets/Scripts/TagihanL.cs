using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TagihanL : MonoBehaviour
{
    public Slider timerSlider;
    public Text timerText;
    public float TagihanListrik;
    public int Pembayaran;

    private bool stopTimer;
    // Start is called before the first frame update
    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = TagihanListrik;
        timerSlider.value = TagihanListrik;
    }

    // Update is called once per frame
    void Update()
    {
        float time = TagihanListrik - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (time <= 0)
        {
            stopTimer = true;
        }

        if (stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = time;
        }
    }

    public void Bayar()
    {
        TagihanListrik += Pembayaran;
        timerSlider.maxValue = TagihanListrik;
        timerSlider.value = TagihanListrik;
        stopTimer = false;
    }
}
