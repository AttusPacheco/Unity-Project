using Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace View
{
    public class BallView : MonoBehaviour
    {
        private BallController _ballController;
        private BrickController _brickController;

        public void Start()
        {
            _ballController = GetComponent<BallController>();
            _brickController = GetComponent<BrickController>();
        }

        public void Update()
        {
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            switch (collision.gameObject.tag)
            {
                case "Brick":
                    BrickView _brickView = collision.gameObject.GetComponent<BrickView>();
                    _brickView.PerformTakeDamage();
                    _ballController.PerfectAngleReflect(collision);
                    break;
                case "Player":
                    _ballController.CalcBallAngleReflect(collision);
                    break;
                default:
                    _ballController.PerfectAngleReflect(collision);
                    break;
            }
        }
    }   
}