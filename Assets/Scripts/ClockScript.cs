using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI clock;

    private float time;

    void Start()
    {
        time = 0f;    
    }
        
    void Update()
    {
        time += Time.deltaTime;
    }
	private void LateUpdate()
	{
		//clock.text = time.ToString();
		clock.text = FormatTime(time);
	}
	private string FormatTime(float totalSeconds)
	{
		TimeSpan timeSpan = TimeSpan.FromSeconds(totalSeconds);
		return $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}.{timeSpan.Milliseconds / 100}";
	}
}
/* Д.З. Завершити роботу над проєктом 3D
 */
