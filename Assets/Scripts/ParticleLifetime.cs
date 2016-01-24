using UnityEngine;
using System.Collections;

public class ParticleLifetime : MonoBehaviour
{
    public float _Lifetime;
    private float _Timestamp;

    private void Start()
    {
        _Lifetime = Random.Range(0.0f, _Lifetime);
        _Timestamp = Time.realtimeSinceStartup;
    }

    private void Update()
    {
        if(Time.realtimeSinceStartup - _Timestamp > _Lifetime)
        {
            gameObject.SetActive(false);
        }
    }
}
