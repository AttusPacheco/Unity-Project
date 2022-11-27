using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class BallModel : MonoBehaviour
    {
        [Range(0,5)]
        [SerializeField] private float _power;

        [Range(0,10)]
        [SerializeField] private float _speed;

        [Space(10)]
        [Header("Vetor de direção")]
        [SerializeField] private Vector2 _direction;

        public float Power { get => _power; set => _power = value;}
        public float Speed { get => _speed; set => _speed = value;}
        public Vector2 Direction { get => _direction; set => _direction = value;}

        private void Reset()
        {
            
        }
    }
}