using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lives = 3;
    public float rotationSpeed = 2;
    public float movementSpeed = 5;
    public float acceleration = 50f;
    public float deceleration = .1f;

    private Rigidbody2D rigid;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //If user presses W
        if (Input.GetKey(KeyCode.W)){
            rigid.AddForce(transform.right * acceleration);}
        if (Input.GetKey(KeyCode.A)){
            rigid.AddForce(transform.up * acceleration);}
        if (Input.GetKey(KeyCode.S)){
            rigid.AddForce(-transform.right * acceleration);}
        if (Input.GetKey(KeyCode.D)){
            rigid.AddForce(-transform.up * acceleration);}

        if (Input.GetKey(KeyCode.A)){
            transform.rotation *= Quaternion.AngleAxis(5, Vector3.forward);}
        if (Input.GetKey(KeyCode.D)){
            transform.rotation *= Quaternion.AngleAxis(-5, Vector3.forward);}

        rigid.velocity += -rigid.velocity * deceleration;
    }
}
