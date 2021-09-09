

using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player")||other.tag.Equals("Bullet") )
        {
            Score.addScore(10); gameObject.SetActive(false);
        }




    }
    


}
