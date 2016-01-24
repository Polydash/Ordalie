using UnityEngine;
using System.Collections;

public class DigTester : MonoBehaviour
{
    public GameObject _ParticlePrefab;
    public int _ParticleCount;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("Tile")))
            {
                Vector3 origin = hit.point;
                origin.z = 0.0f;
                Collider[] colliders = Physics.OverlapSphere(origin, 1.0f, 1 << LayerMask.NameToLayer("Tile"));
                for(int i=0; i<colliders.Length; ++i)
                {
                    colliders[i].gameObject.SetActive(false);
                }

                int particleCount = Mathf.Min(_ParticleCount, colliders.Length);
                for (int i = 0; i < particleCount; ++i)
                {
                    GameObject instance = Instantiate<GameObject>(_ParticlePrefab);
                    instance.transform.position = origin;
                    float randomX = Random.Range(-75.0f, 75.0f);
                    float randomY = Random.Range(-75.0f, 75.0f);
                    instance.GetComponent<Rigidbody>().velocity = new Vector3(randomX, randomY, 0.0f);
                }
            }
        }
    }
}
