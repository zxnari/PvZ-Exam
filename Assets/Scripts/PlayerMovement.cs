using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 playerPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            transform.position = new Vector2(-9.5f, 2.5f);
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            transform.position = new Vector2(-9.5f, 1.5f);
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            transform.position = new Vector2(-9.5f, 0.5f);
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            transform.position = new Vector2(-9.5f, -0.5f);
        else if (Input.GetKeyDown(KeyCode.Alpha5))
            transform.position = new Vector2(-9.5f, -1.5f);
    }
}
