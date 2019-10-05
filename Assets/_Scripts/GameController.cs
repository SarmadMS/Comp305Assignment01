using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Source file name:GameController
 * Author’s name: Sarmad Siddiqi
 * Last Modified by: Sarmad Siddiqi
 * Date last Modified: October 4th
 * Program description: Changing Score and health as well as Reseting Scene
 * Revison History: 
 * Added Score and Health
 * Added Reseting Scene
 * 
 * 
 * 
 */
public class GameController : MonoBehaviour
{
    private int _score;
    private int _lives;
    public Text livesLabel;
    public Text scoreLabel;
    public int Lives
    {
        get
        {
            return _lives;
        }

        set
        {
            _lives = value;
            if (_lives < 1)
            {

                SceneManager.LoadScene("Main");
            }
            else
            {
                livesLabel.text = "Lives: " + _lives.ToString();
            }

        }
    }
    public int Score
    {
        get
        {
            return _score;
        }

        set
        {
            _score = value;

            scoreLabel.text = "Score: " + _score.ToString();


        }
    }

    void Start()
    {
        Lives = 5;
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
