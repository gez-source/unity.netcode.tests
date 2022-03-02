using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class LightScript : NetworkBehaviour
{
    
    //public NetworkVariable<Color> Colour = new NetworkVariable<Color>();
    
    public static Color RandomColour()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
    
    [ClientRpc]
    //public void ChangeColourClientRpc(Color newColour)
    //public void ChangeColourClientRpc(Color newColour)
    public void ChangeColourClientRpc(float newFloat)
    {
        //GetComponent<Light>().color = newColour;
        Debug.Log("Hello from client: " + newFloat.ToString("N"));
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
