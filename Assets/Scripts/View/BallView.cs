using Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class BallView : MonoBehaviour
    {
        private BallController _ballController;
        private BrickController _brickController;
        private StatsController _statsController;

        public void Start()
        {
            _ballController = GetComponent<BallController>();
            _brickController = GetComponent<BrickController>();
            _statsController = GetComponent<StatsController>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            switch (collision.gameObject.tag)
            {
                case "Brick":
                    BrickView _brickView = collision.gameObject.GetComponent<BrickView>();
                    _brickView.PerformTakeDamage();
                    _ballController.PerfectAngleReflect(collision);
                    _statsController.UpdateScore(1);
                    _ballController.SpeedUp();
                    break;
                case "Player":
                    _ballController.CalcBallAngleReflect(collision);
                    break;
                case "BottomWall":
                    _ballController.PerfectAngleReflect(collision);
                    _statsController.UpdateScore(-10);
                    break;
                default:
                    _ballController.PerfectAngleReflect(collision);
                    break;
            }
        }
    }   
}