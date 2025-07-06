using UnityEngine;


public class OnEnable2 : MonoBehaviour
{
    public GameObject PrefabCubo5;
    public GameObject PrefabCubo6;

    private static bool alreadyEnabled = false;
    private static bool alreadyDisabled = false;

    private GameObject tempGameObject5;
    private GameObject tempGameObject6;

    void OnEnable()
    {
        // Avoid infinite recursion
        if (!alreadyEnabled)
        {
            alreadyEnabled = true;
            tempGameObject5 = Instantiate(PrefabCubo5, new Vector3(-6, 3, 0), Quaternion.identity);
            tempGameObject5.SetActive(true);

            if (tempGameObject6 != null)
            {
                tempGameObject6.SetActive(false);
                
                // tempGameObject6 has already been instantiated
            }


        }

        if (tempGameObject6 != null)
        {
            tempGameObject6.SetActive(false);
            
            // tempGameObject6 has already been instantiated
        }

    }

    void OnDisable()
    {
        // Avoid infinite recursion
        if (!alreadyDisabled)
        {
            alreadyDisabled = true;
            tempGameObject6 = Instantiate(PrefabCubo6, new Vector3(-6, 6, 0), Quaternion.identity);
            tempGameObject6.SetActive(true);

            if (tempGameObject5 != null)
            {
                tempGameObject5.SetActive(false);
                
                // tempGameObject6 has already been instantiated
            }
        }
        if (tempGameObject5 != null)
        {
            tempGameObject5.SetActive(false);
          
            // tempGameObject6 has already been instantiated
        }

    }

    void OnApplicationQuit()
    {
        if (tempGameObject6 != null)
        {
            DestroyImmediate(tempGameObject6);
        }
    }
}
