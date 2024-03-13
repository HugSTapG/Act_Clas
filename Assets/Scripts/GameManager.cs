using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TMP_Text textScore;
    public void AddScore()
    {
        score++;
        textScore.text = score.ToString();
    }
}
