using UnityEditor;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    public Activate Colors;

    public Material redMaterial;
    public Material orangeMaterial;
    public Material yellowMaterial;
    public Material greenMaterial;
    public Material blueMaterial;
    public Material purpleMaterial;

    public GameObject Background1;
    public GameObject Background2;
    public GameObject Background3;
    public GameObject Background4;

    public GameObject Spike1;
    public GameObject Spike2;
    public GameObject Spike3;
    public GameObject Spike4;
    public GameObject Spike5;
    public GameObject Spike6;

    public GameObject Camera;
    void Start()
    {
        
    }
    void Update()
    {
        if (Colors.isRedActive == true)
        {
            Camera.GetComponent<Camera>().backgroundColor = UnityEngine.Color.darkRed;
            Background1.GetComponent<Renderer>().material = redMaterial;
            Background2.GetComponent<Renderer>().material = redMaterial;
            Background3.GetComponent<Renderer>().material = redMaterial;
            Background4.GetComponent<Renderer>().material = redMaterial;
            Spike1.GetComponent<Renderer>().material = redMaterial;
            Spike2.GetComponent<Renderer>().material = redMaterial;
            Spike3.GetComponent<Renderer>().material = redMaterial;
            Spike4.GetComponent<Renderer>().material = redMaterial;
            Spike5.GetComponent<Renderer>().material = redMaterial;
            Spike6.GetComponent<Renderer>().material = redMaterial;
        }
        if (Colors.isOrangeActive)
        {
            Camera.GetComponent<Camera>().backgroundColor = UnityEngine.Color.orangeRed;
            Background1.GetComponent<Renderer>().material = orangeMaterial;
            Background2.GetComponent<Renderer>().material = orangeMaterial;
            Background3.GetComponent<Renderer>().material = orangeMaterial;
            Background4.GetComponent<Renderer>().material = orangeMaterial;
            Spike1.GetComponent<Renderer>().material = orangeMaterial;
            Spike2.GetComponent<Renderer>().material = orangeMaterial;
            Spike3.GetComponent<Renderer>().material = orangeMaterial;
            Spike4.GetComponent<Renderer>().material = orangeMaterial;
            Spike5.GetComponent<Renderer>().material = orangeMaterial;
            Spike6.GetComponent<Renderer>().material = orangeMaterial;
        }
        if (Colors.isYellowActive == true)
        {
            Camera.GetComponent<Camera>().backgroundColor = UnityEngine.Color.gold;
            Background1.GetComponent<Renderer>().material = yellowMaterial;
            Background2.GetComponent<Renderer>().material = yellowMaterial;
            Background3.GetComponent<Renderer>().material = yellowMaterial;
            Background4.GetComponent<Renderer>().material = yellowMaterial;
            Spike1.GetComponent<Renderer>().material = yellowMaterial;
            Spike2.GetComponent<Renderer>().material = yellowMaterial;
            Spike3.GetComponent<Renderer>().material = yellowMaterial;
            Spike4.GetComponent<Renderer>().material = yellowMaterial;
            Spike5.GetComponent<Renderer>().material = yellowMaterial;
            Spike6.GetComponent<Renderer>().material = yellowMaterial;
        }
        if (Colors.isGreenActive == true)
        {
            Camera.GetComponent<Camera>().backgroundColor = UnityEngine.Color.darkGreen;
            Background1.GetComponent<Renderer>().material = greenMaterial;
            Background2.GetComponent<Renderer>().material = greenMaterial;
            Background3.GetComponent<Renderer>().material = greenMaterial;
            Background4.GetComponent<Renderer>().material = greenMaterial;
            Spike1.GetComponent<Renderer>().material = greenMaterial;
            Spike2.GetComponent<Renderer>().material = greenMaterial;
            Spike3.GetComponent<Renderer>().material = greenMaterial;
            Spike4.GetComponent<Renderer>().material = greenMaterial;
            Spike5.GetComponent<Renderer>().material = greenMaterial;
            Spike6.GetComponent<Renderer>().material = greenMaterial;
        }
        if (Colors.isBlueActive == true)
        {
            Camera.GetComponent<Camera>().backgroundColor = UnityEngine.Color.darkBlue;
            Background1.GetComponent<Renderer>().material = blueMaterial;
            Background2.GetComponent<Renderer>().material = blueMaterial;
            Background3.GetComponent<Renderer>().material = blueMaterial;
            Background4.GetComponent<Renderer>().material = blueMaterial;
            Spike1.GetComponent<Renderer>().material = blueMaterial;
            Spike2.GetComponent<Renderer>().material = blueMaterial;
            Spike3.GetComponent<Renderer>().material = blueMaterial;
            Spike4.GetComponent<Renderer>().material = blueMaterial;
            Spike5.GetComponent<Renderer>().material = blueMaterial;
            Spike6.GetComponent<Renderer>().material = blueMaterial;
        }
        if (Colors.isPurpleActive == true)
        {
            Camera.GetComponent<Camera>().backgroundColor = UnityEngine.Color.darkMagenta;
            Background1.GetComponent<Renderer>().material = purpleMaterial;
            Background2.GetComponent<Renderer>().material = purpleMaterial;
            Background3.GetComponent<Renderer>().material = purpleMaterial;
            Background4.GetComponent<Renderer>().material = purpleMaterial;
            Spike1.GetComponent<Renderer>().material = purpleMaterial;
            Spike2.GetComponent<Renderer>().material = purpleMaterial;
            Spike3.GetComponent<Renderer>().material = purpleMaterial;
            Spike4.GetComponent<Renderer>().material = purpleMaterial;
            Spike5.GetComponent<Renderer>().material = purpleMaterial;
            Spike6.GetComponent<Renderer>().material = purpleMaterial;
        }
    }
}
