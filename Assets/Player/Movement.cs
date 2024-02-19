using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Movement : MonoBehaviour
    {
        public Rigidbody2D PlayerRB;
        public float moveX;
        
        private void Start()
        {
            
        }

        private void Update()
        {
        
        }

        private void FixedUpdate()
        {
            
        }

        private void HandleMovement()
        {
            moveX = Input.GetAxisRaw("Horizontal");
        }
        
        private void Move()
        {
            PlayerRB.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
        }
    }
}

