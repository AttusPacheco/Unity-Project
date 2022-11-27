using Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class BrickController : MonoBehaviour
    {
        private BrickModel _brickModel; 

        public void Start()
        {
            _brickModel = GetComponent<BrickModel>();
        }

        public void Damage(int damage)
        {
            _brickModel.Damage(damage);
        }
    }
}