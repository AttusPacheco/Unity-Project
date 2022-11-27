using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class BrickModel : MonoBehaviour
    {
        [SerializeField] private float _health = 1;

        public float Health { get => _health; set => _health = value;}

        public void Damage(int damage)
        {
            _health -= damage;
            Destroy();
        }

        private void Destroy()
        {
            if (_health == 0)
            {
                Destroy(gameObject, 0.05f);
            }
        }
    }
}