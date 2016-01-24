using UnityEngine;
using System.Collections;

public class TileMgr : MonoBehaviour
{
    public GameObject _TilePrefab;
    public float _Width;
    public float _Height;
    public float _Size;

    private void Start()
    {
        for(float x = -_Width/2.0f; x < _Width/2.0f; x += _Size)
        {
            for(float y = -_Height/2.0f; y < _Height/2.0f; y += _Size)
            {
                GameObject instance = Instantiate<GameObject>(_TilePrefab);
                instance.transform.position = new Vector3(x, y);
                instance.transform.localScale = new Vector3(_Size, _Size, instance.transform.localScale.z);
                instance.transform.parent = transform;
            }
        }
    }
}
