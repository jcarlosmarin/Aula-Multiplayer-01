using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class SpawnControl : NetworkBehaviour
{
    [SerializeField] GameObject physicsObjectPrefab;
    [SerializeField] int numObjects = 3;

    public void SpawnObjects()
    {
        if (!IsServer)
            return;

        for (int i = 0; i < numObjects; i++)
        {
            //Instantiate
            GameObject go = NetworkObjectPool.Singleton.GetNetworkObject
                (physicsObjectPrefab, new Vector3(Random.Range(-1, 1), 10f, Random.Range(-1, 1)), Quaternion.identity).gameObject;

            //Realmente "Spawnar" o objeto
            go.GetComponent<NetworkObject>().Spawn();
        }
    }
}
