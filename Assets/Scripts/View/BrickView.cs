using Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace View
{
    public class BrickView : MonoBehaviour
    {
        private BrickController _brickController;

        public void Start()
        {
            _brickController = GetComponent<BrickController>();
        }

        public void PerformTakeDamage()
        {
            _brickController.Damage(1);
        }
    }   
}