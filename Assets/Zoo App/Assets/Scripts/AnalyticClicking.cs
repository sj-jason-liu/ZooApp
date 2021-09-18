using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticClicking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClickEvent()
    {

        AnalyticsResult result = AnalyticsEvent.Custom("Button Clicked", new Dictionary<string, object>
        {
            {"selected_animal", gameObject.name },
            {"time_elapsed", Time.timeSinceLevelLoad }
        });
        Debug.Log(gameObject.name + " clicked!");
        Debug.Log("Analytics result: " + result);
    }
}
