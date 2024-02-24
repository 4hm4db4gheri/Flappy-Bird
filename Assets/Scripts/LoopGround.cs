using UnityEngine;

public class InfiniteMove : MonoBehaviour
{
    [SerializeField] private float _speed = 1.5f;
    [SerializeField] private float _width = 6f;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        // Move the platform to the left
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        // Check if the platform has moved beyond a certain point
        if (transform.position.x < _startPosition.x - _width)
        {
            // Reset the position to the starting position
            transform.position = _startPosition;
        }
    }
}
