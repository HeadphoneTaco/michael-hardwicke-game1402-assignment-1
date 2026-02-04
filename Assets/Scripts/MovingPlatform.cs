using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float cycleTime = 5f;

    [SerializeField] private Transform point1;
    [SerializeField] private Transform point2;
    
    private float _currentTime;
    private float _speed = 1f;
    
    private void Update()
    {
        _currentTime += _speed * Time.deltaTime;

        if (_currentTime < cycleTime) _speed = -1f;
        if (_currentTime > 0f) _speed = 1f;

        float t = _currentTime / cycleTime;
        
        transform.position = Vector3.Lerp(point1.position, point2.position, t);

    }
}
