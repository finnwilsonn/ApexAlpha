using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI TimerText;

    [Header("Timer Settings")]
    public float CurrentTime;
    public bool CountDown;

   
    // Update is called once per frame
    void Update()
    {
        // Update current time based on countdown mode
        CurrentTime = CountDown ? CurrentTime -= Time.deltaTime : CurrentTime += Time.deltaTime;
        TimerText.text = CurrentTime.ToString("0.00");
    }

    // Method to add time to the timer
    public void AddTime(float timeToAdd)
    {
            CurrentTime -= timeToAdd; // Decrease the time when counting
            if (CurrentTime < 0)
            {
                CurrentTime = 0; // Ensure time doesn't go negative
            }
        }

    // Method to get the current time
    public float GetFinalTime()
    {
        return CurrentTime;
    }

}

