using Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class BallController : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;
        private BallModel _ballModel; 

        public void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _ballModel = GetComponent<BallModel>();

            _rigidbody.velocity = _ballModel.Direction * _ballModel.Speed;
        }

        public void PerfectAngleReflect(Collision2D collision)
        {
            AngleChange(
                Vector2.Reflect(_ballModel.Direction, collision.contacts[0].normal)
            );
        }

        public void CalcBallAngleReflect(Collision2D collision)
        {
            float playerPixels = 120f;
            float unitScaleHalfPlayerPixels = playerPixels / 2 / 100;
            float scaleFactorPut1Dot180Range = 180 / playerPixels;
            float angleDegScale = (
                    (collision.transform.position.x - this.transform.position.x) + unitScaleHalfPlayerPixels
                ) * scaleFactorPut1Dot180Range;
            float angleDeg = angleDegScale * 100f;
            float angleRad = angleDeg * Mathf.PI / 180f;

            AngleChange(
                new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad))
            );
        }

        private void AngleChange(Vector2 vector2)
        {
            _ballModel.Direction = vector2;
            _rigidbody.velocity = _ballModel.Direction * _ballModel.Speed * _ballModel.Power;

        }
    }
}