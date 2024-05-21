using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PointLIghtRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Light pointLightR;
    // Update is called once per frame
    string Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
           // pointLightR.enabled = !pointLightR.enabled;
             pointLightR.enabled = true;
            return "true";
        }

        // Turn off the light with the 'O' key
        if (Input.GetKeyDown(KeyCode.V))
        {
            pointLightR.enabled = false;
            return "false";
        }
        return "";
    }
}
