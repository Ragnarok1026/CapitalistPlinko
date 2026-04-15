using UnityEngine;

public class ObstacleColors : MonoBehaviour
{
    public SpriteRenderer[] obstacles;
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
        foreach (SpriteRenderer obstacle in obstacles)
        {
            if (colors.isRedActive)
            {
               obstacle.material = redMaterial;
            }
            if (colors.isOrangeActive)
            {
                obstacle.material = orangeMaterial;
            }
            if (colors.isYellowActive)
            {
                obstacle.material = yellowMaterial;
            }
            if (colors.isGreenActive)
            {
                obstacle.material = greenMaterial;
            }
            if (colors.isBlueActive)
            {
                obstacle.material = blueMaterial;
            }
            if (colors.isPurpleActive)
            {
                obstacle.material = purpleMaterial;
            }
        } 
    }
}
