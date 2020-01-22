using UnityEngine;
using System.Collections;


public class ittarikitari : MonoBehaviour
{
    [SerializeField]
    private Vector3 _startPosition;

    [SerializeField]
    private Vector3 _targetPosition;

    [SerializeField]
    private float _duration = 1f;

    private float _time = 0;
    //private int _dirFactor = 1;
    private bool _inverse = false;

    private void Update()
    {
        _time += Time.deltaTime;

        // 指定時間を過ぎたら向きを逆に
        if (_time >= _duration)
        {
            _time = 0;
            _inverse = !_inverse;
        }

        // 時間を媒介変数として計算（0 - 1）
        float t = _time / _duration;

        if (_inverse)
        {
            transform.position = Vector3.Lerp(_startPosition, _targetPosition, 1f - t);
        }
        else
        {
            transform.position = Vector3.Lerp(_startPosition, _targetPosition, t);
        }
    }
}