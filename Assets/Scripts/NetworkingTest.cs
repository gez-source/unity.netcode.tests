using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Random = UnityEngine.Random;

public class NetworkingTest : MonoBehaviour
{
    public GameObject lightPrefab;

    private GameObject lightInstance;

    // Start is called before the first frame update
    void Start()
    {
        //NetworkManager.Singleton.StartServer();
        
    }

    // Update is called once per frame
    void Update()
    {
        //NetworkManager.

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 30), "Change colour"))
        {
            //FindObjectOfType<LightScript>().ChangeColourClientRpc(LightScript.RandomColour());
            FindObjectOfType<LightScript>().ChangeColourClientRpc(Random.value);
        }
        
        if (GUI.Button(new Rect(0, 50, 100, 30), "Spawn light"))
        {
            if (NetworkManager.Singleton.IsServer)
            {
                lightInstance = Instantiate(lightPrefab, Vector3.zero, Quaternion.identity);
                lightInstance.GetComponent<NetworkObject>().Spawn();
            }
            if (NetworkManager.Singleton.IsClient)
            {
                
            }

        }
    }

    private void OnDrawGizmos()
    {
        
        
    }
}
