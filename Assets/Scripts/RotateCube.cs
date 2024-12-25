using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField, Range(-100f, 100f)] private float _speed;

    private void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
