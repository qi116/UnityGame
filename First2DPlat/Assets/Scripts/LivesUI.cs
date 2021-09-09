using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public Text lives;


    private void Start()
    {
        lives = gameObject.GetComponent<Text>();
    }
    void Update()
    {
        lives.text = "lives: " + (Score.playerLives).ToString("0");
    }
}
