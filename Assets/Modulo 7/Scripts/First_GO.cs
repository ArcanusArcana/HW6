using UnityEngine;

public class First_GO : MonoBehaviour
{
    
    public bool selector=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void FixedUpdate()
    {
       Renderer render =GetComponent<Renderer>();

        if (selector==true)
        {
            render.material.color = Color.white;
            selector = false;
        }
        else
        {
            render.material.color=Color.black;
            selector = true;
        }
    }
}
