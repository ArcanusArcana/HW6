using UnityEngine;

public class Fourth_GO : MonoBehaviour
{
    public GameObject cubo;
    public GameObject capsula;

    private First_GO s1_ref;
    private Second_GO s2_ref;
    public bool boleana_1;
    public bool boleana_2;
    public bool boleana_3;

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
        s1_ref = cubo.GetComponent<First_GO>();
        s2_ref = capsula.GetComponent<Second_GO>();
        boleana_1 = s1_ref.selector;
        boleana_2 = s2_ref.selector;
        //Debug.Log(s1_ref.selector);
        //Debug.Log(s2_ref.selector);
        boleana_3 = boleana_1 || boleana_2;
        if ((boleana_1 || boleana_2) == true)
        {
            renderer.material.color = Color.red;

        }
        else
        {
            renderer.material.color = Color.blue;

        }

    }
}