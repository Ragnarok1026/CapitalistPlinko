using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Shop : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;


    private void Start()
    {
        CreateItemButton1(Color.GetSprite(Color.ItemType.Red), "Red", Color.GetCost(Color.ItemType.Red), 0);
        CreateItemButton1(Color.GetSprite(Color.ItemType.Orange), "Orange", Color.GetCost(Color.ItemType.Orange), 1);
        CreateItemButton1(Color.GetSprite(Color.ItemType.Yellow), "Yellow", Color.GetCost(Color.ItemType.Yellow), 2);
        CreateItemButton1(Color.GetSprite(Color.ItemType.Green), "Green", Color.GetCost(Color.ItemType.Green), 3);
        CreateItemButton2(Color.GetSprite(Color.ItemType.Blue), "Blue", Color.GetCost(Color.ItemType.Blue), 4);
        CreateItemButton3(Color.GetSprite(Color.ItemType.Purple), "Purple", Color.GetCost(Color.ItemType.Purple), 5);
    }
    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void CreateItemButton1(Sprite itemSprite, string itemName, int itemcost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        shopItemRectTransform.anchoredPosition = new Vector2(450 * positionIndex, 0);

        shopItemTransform.Find("nameText").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemcost.ToString());

        shopItemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;
        shopItemTransform.gameObject.SetActive(true);
    }
    private void CreateItemButton2(Sprite itemSprite, string itemName, int itemcost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        shopItemRectTransform.anchoredPosition = new Vector2(50 * positionIndex, -50 * positionIndex);

        shopItemTransform.Find("nameText").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemcost.ToString());

        shopItemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;
        shopItemTransform.gameObject.SetActive(true);
    }
    private void CreateItemButton3(Sprite itemSprite, string itemName, int itemcost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        shopItemRectTransform.anchoredPosition = new Vector2(230 * positionIndex, -40 * positionIndex);

        shopItemTransform.Find("nameText").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemcost.ToString());

        shopItemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;
        shopItemTransform.gameObject.SetActive(true);
    }

    public void OnItemButtonClicked(string itemName)
    {
        if (itemName == "Red")
        {
            Debug.Log("Red item button clicked!");
        }
        if (itemName == "Orange")
        {
            Debug.Log("Orange item button clicked!");
        }
        if (itemName == "Yellow")
        {
            Debug.Log("Yellow item button clicked!");
        }
        if (itemName == "Green")
        {
            Debug.Log("Green item button clicked!");
        }
        if (itemName == "Blue")
        {
            Debug.Log("Blue item button clicked!");
        }
        if (itemName == "Purple")
        {
            Debug.Log("Purple item button clicked!");
        }
    }

}
