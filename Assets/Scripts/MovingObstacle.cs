using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 3f;

    private float startX;
    private bool movingRight = true;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        float movement = moveSpeed * Time.deltaTime;

        if (movingRight)
        {
            transform.Translate(movement, 0f, 0f);

            if (transform.position.x >= startX + moveDistance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(-movement, 0f, 0f);

            if (transform.position.x <= startX - moveDistance)
            {
                movingRight = true;
            }
        }
    }
}