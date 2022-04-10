using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  public Ball ball;
  public Paddle playerPaddle;
  public Paddle computerPaddle;
  private int _playerScore;
  public Text playerScoreText;
  private int _computerScore;
  public Text computerScoreText;
  public void PlayerScore()
  {
    _playerScore++;
    this.playerScoreText.text = _playerScore.ToString();
    Reset();
  }
  public void ComputerScore()
  {
    _computerScore++;
    this.computerScoreText.text = _computerScore.ToString();
    Reset();
  }
  private void Reset()
  {
    this.playerPaddle.ResetPosition();
    this.computerPaddle.ResetPosition();
    this.ball.ResetPosition();
    this.ball.AddStartingForce();
  }
}
