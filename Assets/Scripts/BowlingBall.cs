using UnityEngine;

public class BowlingBall : MonoBehaviour {

    public float Speed;

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
        _rigidBody.velocity = new Vector3(0.0f, 0.0f, Speed);
        _audioSource.Play();
    }

    void Update ()
    {
	
	}
}
