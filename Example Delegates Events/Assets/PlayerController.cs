using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    void Update()
    {
        // moving object to left
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
