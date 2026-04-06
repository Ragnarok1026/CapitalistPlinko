using UnityEngine;

public class Interface : MonoBehaviour
{
    public interface IBuyable
    {
        void BuyColor(int index);
        void BuyBackground(int index);
        void BuyObstacle(int index);
    }
    public interface IUseable
    {
        void UseColor(int index);
        void UseBackground(int index);
        void UseObstacle(int index);
    }
}
