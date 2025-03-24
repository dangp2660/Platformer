using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    void Start()
    {
        upadateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore(int point)
    {
        score += point;
        upadateScore();
    }

    private void upadateScore()
    {
        scoreText.text = score.ToString();
    }

}
