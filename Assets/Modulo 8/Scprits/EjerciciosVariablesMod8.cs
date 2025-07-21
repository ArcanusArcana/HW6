using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int var1 = 0;
    float var2 = 1.0f;

    float var3 = 2.0f;
    float var4 = 4.0f;
    int var5;
    
    int var6;
    public GameObject cubo;
    string var7="Red";
    float pi = 3.141592654f;
    string nombreCompleto = "Cesar Alberto Vazquez";
    string valor1Str = "1500";
    string valor2Str = "3200";
    string oracion = "Hola Mundo";
    string resultado = "";
    string oracion2 = "Hola a todos en Unity";
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
        Renderer render = GetComponent<Renderer>();
        Renderer renderCubo = cubo.GetComponent<Renderer>();

        var1 +=1;
        var2 *= 1.0f;
        var6= Random.Range(1, 100);
        // Debug.Log(var1);
        //Debug.Log(var2);
        var5 = (int)var3 / (int)var4;
        //Debug.Log(var5);

        if (var6 % 2 == 0)
        {
            render.material.color = Color.white;
        }
        else 
        { 
            render.material.color = Color.black;
        }

        switch (var7)
        {
            case "Red":
                renderCubo.material.color = Color.red; break;

            case "Blue":
                renderCubo.material.color = Color.blue; break;
            case "Green":
                renderCubo.material.color = Color.green; break;

        }
        string num2txt = pi.ToString("F4");
        Debug.Log(num2txt);

        // Asumimos que sabemos las posiciones exactas
        string nombre = nombreCompleto.Substring(0, 5);       // "Cesar"
        string segundoNombre = nombreCompleto.Substring(6, 7); // "Alberto"
        string apellido = nombreCompleto.Substring(14);        // "Vazquez"
        //Debug.Log(nombre);
        //Debug.Log(segundoNombre);
        //Debug.Log(apellido);
        string[] partes = nombreCompleto.Split(' ');

        // Acceso individual
        string nombre2 = partes[0];         // "Cesar"
        string segundoNombre2 = partes[1];  // "Alberto"
        string apellido2 = partes[2];
        //Debug.Log(nombre2);
        //Debug.Log(segundoNombre2);
        // Debug.Log(apellido2);
        // Variables numéricas
        int valor1, valor2;

        // Intentamos convertir los strings a enteros
        bool exito1 = int.TryParse(valor1Str, out valor1);
        bool exito2 = int.TryParse(valor2Str, out valor2);

        if (exito1 && exito2)
        {
            int resultado = valor1 + valor2;
            Debug.Log("Resultado de la suma: " + resultado);  // Salida: 4700
        }
        else
        {
            Debug.Log("Error al convertir los valores.");
        }
        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)  // Índices pares
            {
                resultado += oracion[i];
            }
        }

        Debug.Log("Caracteres en índices pares: " + resultado);
        // Salida: Hl ud



        // Eliminamos los primeros 5 caracteres
        string resultado2 = oracion2.Substring(5);

        Debug.Log("Oración original: " + oracion2);
        Debug.Log("Sin los primeros 5 caracteres: " + resultado2);
        // Salida: "a todos en Unity"
    }
}
