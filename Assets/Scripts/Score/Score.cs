using UnityEngine;

public class Score : MonoBehaviour, IScore
{
    private int score;

    public Score(int score)
    {
        this.score = score;
    }

    public void OperationOfScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
