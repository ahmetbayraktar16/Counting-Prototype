using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI CounterText;

    private int count = 0;

    private void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        count += 1;
        CounterText.text = "Count : " + count;
    }
}
