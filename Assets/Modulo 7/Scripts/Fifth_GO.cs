using UnityEngine;

public class Fifth_GO : MonoBehaviour
{
    public GameObject esfera1;
    public GameObject esfera2;

    private Third_GO s1_ref;
    private Fourth_GO s2_ref;
    bool boleana_1;
    bool boleana_2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Renderer renderer = GetComponent<Renderer>();
        s1_ref = esfera1.GetComponent<Third_GO>();
        s2_ref = esfera2.GetComponent<Fourth_GO>();
        boleana_1 = s1_ref.boleana_3;
        boleana_2 = s2_ref.boleana_3;
        //Debug.Log(s1_ref.selector);
        //Debug.Log(s2_ref.selector);
        if ((boleana_1 || boleana_2) == true)
        {
            renderer.material.color = Color.green;

        }
        else
        {
            renderer.material.color = Color.yellow;

        }

    }
}
