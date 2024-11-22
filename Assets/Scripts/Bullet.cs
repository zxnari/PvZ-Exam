using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 Velocity { get; set; }

    private void Update()
    {
        transform.position += (Vector3)(Velocity * Time.deltaTime);
        if (transform.position.x > 10f)
        {
            BulletFlyweight.Instance.ReturnBullet(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            BulletFlyweight.Instance.ReturnBullet(this.gameObject);
        }
    }
}