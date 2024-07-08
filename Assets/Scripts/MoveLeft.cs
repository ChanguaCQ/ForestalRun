using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 25;
    private float accelerationSpeed = 5f;
    [SerializeField] private float timerIncrement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerIncrement += Time.deltaTime;

        if (timerIncrement>=10) {
            timerIncrement=0f;
            speed += accelerationSpeed;
            }
            
            transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
