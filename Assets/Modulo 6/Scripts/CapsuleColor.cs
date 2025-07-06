using UnityEngine;

public class CapsuleColor : MonoBehaviour
{
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
        // Get the Renderer component of the cube
        Renderer capRenderer = GetComponent<Renderer>();

        // Generate random RGB values between 0 and 1
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        // Set the color
        Color randomColor = new Color(r, g, b);

        // Apply the color to the cube's material
        capRenderer.material.color = randomColor;
    }
}
