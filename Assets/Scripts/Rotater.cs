using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField, Range(-100f, 100f)] private float _speed;

    private void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
