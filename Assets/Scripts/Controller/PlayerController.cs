using Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;
        private PlayerModel _playerModel; 

        public void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _playerModel = GetComponent<PlayerModel>();
        }

        public void Update()
        {
        
        }

        public void Move(float horizontalAxis)
        {
            _rigidbody.velocity = new Vector2(horizontalAxis * _playerModel.Speed, _rigidbody.position.y);
        }
    }
}

