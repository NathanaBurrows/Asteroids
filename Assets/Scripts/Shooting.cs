using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Functions
{

    public class Shooting : MonoBehaviour
    {
        //Stores the object we want to Instantiate
        public GameObject projectilePrefab;
        //Speed at whuch the projectile will be flung
        public float projectileSpeed = 20f;
        //Rate of fire
        public float shootRate = 0.1f;
        //Timer to count up to shootRate
        private float shootTimer = 0f;
        //Container for the RigidBody2D
        private Rigidbody2D rigid;

        // Use this for initialization
        void Start()
        {
            //Get the rigidbody component
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            //Increase the timer
            shootTimer += Time.deltaTime;
            // AND                      = '&&'
            // OR                       = '||'
            // Greater than or equal to = '>='
            // Less than or equal to    = '<='
            // Not equal to             = '!='
            // Is equal to              = '=='
            //IF space bar is pressed AND shootTimer >= shootRate
            if (Input.GetKey(KeyCode.Space) && shootTimer >= shootRate)
            {
                //CALL Shoot()
                Shoot();
                //RESET shootTimer = 0
                shootTimer = 0;
            }
        }
        void Shoot()
        {
            print("shooting projectile");

            // Instantiate a projectile
            Instantiate(projectilePrefab);
            // Send projectile flying forward
            // Apply recoil to player
        }
    }
}