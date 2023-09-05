using System;
using System.Collections;
using UnityEngine;

public class GreatBall : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;

    [SerializeField] private Rigidbody _rb;

    [SerializeField, Min(0.001f)] private float _force;


    [SerializeField] private FloatVariable _multiplier;

    [SerializeField] private FloatVariable _maxTime;
    [SerializeField] private AnimationCurve _verticalVel;
    private float _currentTime;

    public void Shoot()
    {
        _shootCoroutine = StartCoroutine(ShootCor());
    }

    private Coroutine _shootCoroutine;
    private IEnumerator ShootCor()
    {
        var firstKey = _verticalVel.keys[0];
        for (int i = 0; i < 100; i++)
        {
            Debug.Log("Hay coroutine");
            _rb.AddTorque(firstKey.value * _force * _multiplier.Value* Vector3.right, ForceMode.Acceleration);
            yield return new WaitForFixedUpdate();
        }

        _shootCoroutine = null;
    }
    
    private void FixedUpdate()
    {
        var angularVelocity = _rb.angularVelocity;
        
        HorizontalAngularVelocity(ref angularVelocity);
        VerticalMovement(ref angularVelocity);

        _rb.angularVelocity = angularVelocity;
    }

    private void VerticalMovement(ref Vector3 angularVelocity)
    {
        if(_shootCoroutine != null) return;
        Debug.Log("Hay vertical");
        _currentTime += Time.fixedDeltaTime;
        var x = _verticalVel.Evaluate(_currentTime / _maxTime.Value);
        //TEMRINAR EL JUEGO
        if (x <= 0) Debug.Log("Termino el juego");
        
        angularVelocity.x = x;
    }

    private void HorizontalAngularVelocity(ref Vector3 angularVelocity)
    {
        angularVelocity.z = _force * -_input.H;
    }
}
