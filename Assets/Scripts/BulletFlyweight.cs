using System.Collections.Generic;
using UnityEngine;

public class BulletFlyweight : Singleton<BulletFlyweight>
{
    public GameObject bulletPrefab;
    private Queue<GameObject> bulletPool = new Queue<GameObject>();
    [SerializeField] private Material sharedBulletMaterial;
    [SerializeField] private int initialPoolSize = 12;

    private void Start()
    {
        for (int i = 0; i < initialPoolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            Renderer bulletRenderer = bullet.GetComponent<Renderer>();
            
            if (bulletRenderer != null)
            {
                bulletRenderer.sharedMaterial = sharedBulletMaterial; 
            }
             
            bullet.SetActive(false);
            bulletPool.Enqueue(bullet);
        }
    }

    public GameObject GetBullet()
    {
        if (bulletPool.Count > 0)
        {
            GameObject bullet = bulletPool.Dequeue();

           Renderer bulletRenderer = bullet.GetComponent<Renderer>();
            
            if (bulletRenderer != null)
            {
                bulletRenderer.sharedMaterial = sharedBulletMaterial; 
            }
            
            bullet.SetActive(true);
            return bullet; 
        }
        else
        {
            Debug.Log("No Bullets!");
            return null;
            //return Instantiate(bulletPrefab);
        }
    }

    public void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        bulletPool.Enqueue(bullet);
    }
}