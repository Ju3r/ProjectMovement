using UnityEngine;

public class MovementCube : MonoBehaviour
{
    private float _speed = 2f;
    private Vector3 _rotation = new Vector3(0f, 75f, 0f);
    private Vector3 _increase = new Vector3(0.1f, 0.1f, 0.1f);

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
        transform.Rotate(_rotation * Time.deltaTime);
        transform.localScale += _increase * Time.deltaTime;
    }
}
