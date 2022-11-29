using Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class BrickController : MonoBehaviour
    {
        public AudioSource _damageAudio;
        private BrickModel _brickModel; 

        public void Start()
        {
            _brickModel = GetComponent<BrickModel>();
        }

        public void Damage(int damage)
        {
            _damageAudio.Play();
            _brickModel.Damage(damage);
        }
    }
}