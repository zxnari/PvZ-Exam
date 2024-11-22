using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform spawnPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnBullet(new Vector2(10, 0f));
        }
    }

    void SpawnBullet(Vector2 velocity)
    {
        GameObject bulletObject = BulletFlyweight.Instance.GetBullet();
        bulletObject.transform.position = spawnPoint.position;

        Bullet bullet = bulletObject.GetComponent<Bullet>();
        bullet.Velocity = velocity;
    }
}