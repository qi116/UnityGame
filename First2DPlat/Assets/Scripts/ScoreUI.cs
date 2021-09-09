using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text score;

    private void Start()
    {
        score = gameObject.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " +(Score.currScore + Score.score).ToString("0");
    }
}
