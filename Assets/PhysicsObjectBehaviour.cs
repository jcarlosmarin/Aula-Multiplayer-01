using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PhysicsObjectBehaviour : NetworkBehaviour
{
    [SerializeField] GameObject prefab;

    void Update()
    {
        if (!IsServer)
            return;

        if (gameObject.transform.position.y < -2f)
        {
            this.NetworkObject.Despawn();
        }
    }
}
