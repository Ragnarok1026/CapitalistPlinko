using UnityEngine;
using System.IO;

public class BallColor : MonoBehaviour
{
    public Activate colors;

    public Material redMaterial;
    public Material orangeMaterial;
    public Material yellowMaterial;
    public Material greenMaterial;
    public Material blueMaterial;
    public Material purpleMaterial;

    void Start()
    {
        
    }
    void Update()
    {
        if (colors.isRedActive == true)
        {
            GetComponent<Renderer>().material = redMaterial;
        }
        if (colors.isOrangeActive == true)
        {
            GetComponent<Renderer>().material = orangeMaterial;
        }
        if (colors.isYellowActive == true)
        {
            GetComponent<Renderer>().material = yellowMaterial; 
        }
        if (colors.isGreenActive == true)
        {
            GetComponent<Renderer>().material = greenMaterial;
        }
        if (colors.isBlueActive == true)
        {
            GetComponent<Renderer>().material = blueMaterial;
        }
        if (colors.isPurpleActive == true)
        {
            GetComponent<Renderer>().material = purpleMaterial;
        }
    }
}
