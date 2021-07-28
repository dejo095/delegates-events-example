using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    private Text UILabel;


    private void Awake() {
        UILabel = GetComponentInChildren<Text>();
        UILabel.text = "";
    }

    private void OnEnable() {
        // subscribing listener onto our event
        DoorEnteredTrigger.onDoorTriggerEnter += updateScore;
    }

    private void OnDisable() {
        
        // unsubscribing listener from our event
        DoorEnteredTrigger.onDoorTriggerEnter -= updateScore;
    }

    // Method thats called when our listener gets triggered
    private void updateScore(string value) {
        Debug.Log("event invoked");
        UILabel.text = value;
    }

}
