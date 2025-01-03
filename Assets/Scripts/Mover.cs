using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 1f;

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
