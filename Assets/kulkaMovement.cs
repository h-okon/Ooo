using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kulkaMovement : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    public static float moveSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public static void setSpeed(int speed)
    {
        Debug.Log("Ustawiam predkosc: " + speed);
        moveSpeed = speed;

    }
    private void setRotation(Vector2 p1)
    {
            float deg = Mathf.Rad2Deg * Mathf.Atan(p1.y / p1.x);

            if (p1.x > 0 && p1.y > 0)      
            {
                deg = (deg * -1) + 90;
            }
            else if (p1.x > 0 && p1.y < 0)
            {
                deg = (deg * -1) + 90;
            }
            else if (p1.x < 0 && p1.y < 0)
            {
                deg = (deg * -1) + 270;
            }
            else                   
            {
                deg = (deg * -1) + 270;

            }
            transform.eulerAngles = Vector3.back * deg;
    }

    // Update is called once per frame
    void Update()
    {
        /*   set position   */
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        setRotation(direction);

    }
}
