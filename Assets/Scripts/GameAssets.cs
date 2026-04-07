using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    public static GameAssets i
    {
        get
        {
            if (_i == null)
            {
                _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            }
            return _i;
        }
    }

    public Sprite Red;
    public Sprite Orange;
    public Sprite Yellow;
    public Sprite Green;
    public Sprite Blue;
    public Sprite Purple;
}
