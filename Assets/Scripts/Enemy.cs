using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 8f; // Adjust speed as needed
    public int direction = 1; // 1 for right, -1 for left

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move based on direction
        transform.position += new Vector3(direction * speed * Time.deltaTime, 0f, 0f);
    }
}