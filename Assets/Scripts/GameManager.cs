using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores(){
        _playerScore++;
        playerScoreText.text =_playerScore.ToString();
        ResetRound();
    }
    public void ComputerScores(){
        _computerScore++;
        computerScoreText.text =_computerScore.ToString();
        ResetRound();

    }  

    private void ResetRound(){
        GameOver();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
  
    }

    public void GameOver(){
        if(_playerScore >= 5 || _computerScore>= 5 && Math.Abs(_playerScore - _computerScore) >= 2){
            SceneManager.LoadScene(0);
        }
    }


    
}
