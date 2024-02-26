using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float _speed = 8f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * (_speed * Time.deltaTime);
    }
}
