using System.Collections.Generic;
using UnityEngine;

public class Update_C : MonoBehaviour
{
    public GameObject PrefafCubo3;
    public List<GameObject> listaDeCubos3;
    public float factorDeEscalamiento;
    public int numCubos = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listaDeCubos3 = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefafCubo3);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
        tempGameObject.AddComponent<Rigidbody>();
        listaDeCubos3.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos3)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objetosParaEliminar.Add(go);

            }

        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listaDeCubos3.Remove(go);
            Destroy(go);


        }
    }
}

