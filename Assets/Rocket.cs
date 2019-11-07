using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    // This function should decide on how to process not perform the action
    private void ProcessInput()
    {
        bool thrust = Input.GetKey(KeyCode.Space);
        bool turn_left = Input.GetKey(KeyCode.A);
        bool turn_right = Input.GetKey(KeyCode.D);

        if (thrust)
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }

        if (turn_left)
        {
            transform.Rotate(Vector3.forward);
        }
        else if (turn_right)
        {
            transform.Rotate(-Vector3.forward);
        }
    }

}
