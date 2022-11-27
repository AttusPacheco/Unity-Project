using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class PlayerModel : MonoBehaviour
    {
        [Range(0,5)]
        [SerializeField] private float _speed;
        [Range(0,5)]
        [SerializeField] private int _life;

        public float Speed { get => _speed; set => _speed = value;}

        public int Life { get => _life; set => _life = value;}
    }
}