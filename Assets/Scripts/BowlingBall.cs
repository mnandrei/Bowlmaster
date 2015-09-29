using UnityEngine;

public class BowlingBall : MonoBehaviour {

    public Vector3 Velocity;

    private Rigidbody _rigidBody;
    private AudioSource _audioSource;

    void Start ()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();

        Launch();
    }

    public void Launch()
    {
        _rigidBody.velocity = Velocity;
        _audioSource.Play();
    }

    void Update ()
    {
	
	}
}
