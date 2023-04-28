using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] Button hostButton;
    [SerializeField] Button clientButton;
    [SerializeField] Button physicsButton;

    [SerializeField] GameObject spawnControl;

    private void Awake()
    {
        hostButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();
        });
        clientButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
        });
        physicsButton.onClick.AddListener(() =>
        {
            spawnControl.GetComponent<SpawnControl>().SpawnObjects();
        });

    }
}
