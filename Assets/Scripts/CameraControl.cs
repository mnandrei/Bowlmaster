using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public BowlingBall Ball;

    private Vector3 _offset;

	void Start ()
    {
        _offset = transform.position - Ball.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.z < 1650)
        {
            transform.position = Ball.transform.position + _offset;
        }
	}
}
