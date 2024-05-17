using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] GameObject object1;

    private bool hasCollided = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasCollided && collision.gameObject == object1)
        {
            hasCollided = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
