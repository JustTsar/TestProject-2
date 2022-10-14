using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CubeMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    private float _startPos;

    private void Start()
    {
        _startPos = transform.position.z;
        Debug.Log(_startPos);
        Debug.Log("Distance " + _distance);
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = Vector3.forward * _speed * Time.fixedDeltaTime;
        if (transform.position.z >= _distance)
        {
            Destroy(gameObject);
        }
    }

}
