using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PointLightLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       dirLight = GameObject.Find("Directional Light").GetComponent<Light>();
    }
    public Light pointLight;
    public Light  pointLightR;
   // public Light pointLightD;
    public Light dirLight ;
    PointLIghtRight pointLIghtRight;
    // Update is called once per frame
    bool enable =true;
    void Update()
    {
        pointLight.enabled =enable;
        dirLight.enabled =enable;
        pointLightR.enabled =enable;
        if (Input.GetKeyDown(KeyCode.L))
        {
            // pointLight.enabled = !pointLight.enabled;
            pointLightR.enabled = true;
           // pointLightD.enabled = !pointLightD.enabled;
            pointLight.enabled = true;
            enable = true;
        }

        // Turn off the light with the 'O' key
        if (Input.GetKeyDown(KeyCode.O))
        {
            pointLight.enabled = false;
            enable = false;
            pointLightR.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Toggle light on/off
            dirLight.enabled = !dirLight.enabled;
        }
    }
}
