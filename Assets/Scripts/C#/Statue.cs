using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    public bool isTriggred = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log(isTriggred);*/
    }

    private void OnTrigger(Collision collision)
    {
        isTriggred = true;
    }
}
