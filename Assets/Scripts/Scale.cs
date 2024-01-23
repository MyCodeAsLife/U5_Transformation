using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxSize;
    [SerializeField] private float _minSize;

    void Update()
    {
        if ((transform.localScale.y > _maxSize && _speed > 0) || (transform.localScale.y < _minSize && _speed < 0))
            _speed *= -1;

        transform.localScale = (transform.localScale * (1 + _speed));
    }
}
