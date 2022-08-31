using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterDisplay : MonoBehaviour
{
    public TextMeshProUGUI counter;

    // Update is called once per frame
    void Update()
    {
        counter.text = CollisionDetector.count.ToString() + "/15";
    }
}
