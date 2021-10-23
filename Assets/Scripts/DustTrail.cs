using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem touchGround;

        private void OnCollisionEnter2D(Collision2D other) {
            
            if (other.gameObject.tag == "Ground")
                touchGround.Play();
            
        }

        private void OnCollisionExit2D(Collision2D other) {
            
            if (other.gameObject.tag == "Ground")
               touchGround.Stop();
        }
}
