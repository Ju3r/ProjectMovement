using UnityEngine;

public class IncreaseCapsuleScale : MonoBehaviour
{
    [SerializeField] private Vector3 _speed;

    private void Update()
    {
        var nextScale = transform.localScale;
        nextScale += _speed * Time.deltaTime;
        transform.localScale = nextScale;
    }
}
