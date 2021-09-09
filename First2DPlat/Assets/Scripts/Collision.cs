
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private bool oneHit = true;
    
    void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.tag.Equals("Enemy"))
        {
            if(oneHit)Score.loseLife();

            oneHit = false;
            Score.currScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }



}
