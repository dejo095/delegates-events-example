using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorEnteredTrigger : MonoBehaviour
{
    // Defining an event
    public static event Action<string> onDoorTriggerEnter;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        // safely, nullcheck, invoking event when something enters collider trigger
        onDoorTriggerEnter?.Invoke("Hey somebody entered my zone");
    }
}
