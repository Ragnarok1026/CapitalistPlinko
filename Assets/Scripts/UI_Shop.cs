using UnityEngine;

public class UI_Shop : MonoBehaviour
{
    private Transform container;
    private Transform ItemTemplate;


    private void Start()
    {
        CreateItemButton(GameAssets.i.Red, "Red", 10, 0);
        CreateItemButton(GameAssets.i.Orange, "Orange", 20, 1);
    }
    private void Awake()
    {
        container = transform.Find("Container");
        ItemTemplate = container.Find("ItemTemplate");
        ItemTemplate.gameObject.SetActive(false);
    }

    private void CreateItemButton(Sprite color, string colorName, int cost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(ItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 100f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);   

        shopItemTransform.Find("Color").GetComponent<UnityEngine.UI.Image>().sprite = color;
        shopItemTransform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = cost.ToString();

        shopItemTransform.Find("Color").GetComponent<UnityEngine.UI.Image>().SetNativeSize();
    }
}
