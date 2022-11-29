using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Controller
{
    public class StatsController : MonoBehaviour
    {
        protected int _score;
        public Text _scoreText;

        void Start()
        {
            _score = 0;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene("SampleScene");
                Time.timeScale = 1f;
            }
        }


        public void UpdateScore(int score)
        {
            _score += score;

            if (_score < 0) {
                Time.timeScale = 0f;
                _scoreText.text = "Perdeu meno, aperta R ae pra tentar dnv";
                return;
            }

            _scoreText.text = "Score: " + _score;
        }
    }
}