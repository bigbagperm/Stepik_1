using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMove : MonoBehaviour
{
    private Rigidbody ball;
    [SerializeField] private float powerImpulse = 80f;
    
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            MoveUp();
        }
    }

    public void MoveUp()
    {
        ball.AddForce(Vector3.forward * powerImpulse);
    }

    public void MoveDown()
    {
        ball.AddForce(Vector3.back * powerImpulse);
    }

    public void MoveLeft()
    {
        ball.AddForce(Vector3.left * powerImpulse);
    }

    public void MovRight()
    {
        ball.AddForce(Vector3.right * powerImpulse);
    }

}
