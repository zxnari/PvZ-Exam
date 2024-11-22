using UnityEditor.Build;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombie : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 1000.0f;
    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.linearVelocityX = -speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Debug.Log("You Lose!");
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }


    }
}
