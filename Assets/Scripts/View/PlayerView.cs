using Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace View
{
    public class PlayerView : MonoBehaviour
    {
        private PlayerController _playerController;

        public void Start()
        {
            _playerController = GetComponent<PlayerController>();
        }

        public void Update()
        {
            float horizontalAxis = Input.GetAxisRaw("Horizontal");
            _playerController.Move(horizontalAxis);
        }
    }   
}