using System.Collections.Generic;
using UnityEngine;

public class Awake2 : MonoBehaviour
{
    public GameObject PrefafCubo;
    private static bool alreadyInstantiated = false;

    void Awake()
    {

        //GameObject tempGameObject = Instantiate<GameObject>(PrefafCubo);
        //GameObject tempGameObject = Instantiate<GameObject>(PrefafCubo, new Vector3(3, 3, 0), Quaternion.identity);
        if (!alreadyInstantiated)
        {
            alreadyInstantiated = true;
            Instantiate(PrefafCubo, new Vector3(3, 3, 0), Quaternion.identity);
        }



    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
