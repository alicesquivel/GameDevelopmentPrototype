using UnityEngine;

public class UpDownObstacle : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 1f;

    private float startY;
    private bool movingUp = true;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        float movement = moveSpeed * Time.deltaTime;

        if (movingUp)
        {
            transform.Translate(0f, movement, 0f);

            if (transform.position.y >= startY + moveDistance)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.Translate(0f, -movement, 0f);

            if (transform.position.y <= startY - moveDistance)
            {
                movingUp = true;
            }
        }
    }
}