using UnityEngine;

public class ShopFunction : MonoBehaviour
{
    public UI_Shop uiShop;

    public void BuyColor()
    {
       if(uiShop.name == "Red")
        {
            Debug.Log("Red selected");
        }
        else
        {
            Debug.Log("Other color selected");
        }
    }
}
