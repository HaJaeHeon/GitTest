using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    [SerializeField] GameObject poolPrefab;
    [SerializeField] int poolSize;

    Queue<GameObject> poolQueue = new Queue<GameObject>();

    private void Awake()
    {
        GameObject parentObject = new GameObject(poolPrefab.name);

        for(int i = 0;  i < poolSize; i++)
        {
            GameObject obj = GameObject.Instantiate(poolPrefab);
            obj.transform.SetParent(parentObject.transform);
            poolQueue.Enqueue(obj);
        }
    }

    public void Get()
    {
        GameObject obj;

        if (poolQueue.Count > 0)
        {
            obj = poolQueue.Dequeue();
            obj.SetActive(true);
        }
    }

    public void Return(GameObject obj)
    {
        Rigidbody2D objRb = obj.GetComponent<Rigidbody2D>();
        objRb.linearVelocity = Vector2.zero;
        objRb.angularVelocity = 0f;
        poolQueue.Enqueue(obj);
        obj.SetActive(false);
    }
}
