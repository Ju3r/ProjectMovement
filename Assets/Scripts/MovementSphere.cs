using UnityEngine;

public class MovementSphere : MonoBehaviour
{
    private float _speed = 1f;

    private void Update()
    {
        var nextPosition = transform.position;
        nextPosition.x += _speed * Time.deltaTime;
        transform.position = nextPosition;
    }
}
