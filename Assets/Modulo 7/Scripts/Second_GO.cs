using UnityEngine;

public class Second_GO : MonoBehaviour
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

    private void FixedUpdate()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (selector==true)
        {
            renderer.material.color = Color.white;
            selector = false;
        }
        else
        {
            renderer.material.color = Color.black;
            selector = true;
        }
        
    }
}
