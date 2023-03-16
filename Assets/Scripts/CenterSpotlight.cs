using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterSpotlight : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 40f;
    [SerializeField] private bool _isClockwise = true;

    private void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(_rotationSpeed * Time.deltaTime, 90));
    }
}
