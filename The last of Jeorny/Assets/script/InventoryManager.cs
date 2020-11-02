using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class InventoryManager : MonoBehaviour
{
    public List<GameObject> itemSlotManager;
    public GameObject itemSlot;
    public RectTransform slotArea; 
    public Sprite clearSlot;

    private float slotSize;
    private int numberOfSlotWidth;
    private int numberOfSlotHeight;
    private int slotCount = 0;
    private int slotGap;

    private float slotWidth;
    private float slotHeight;

    //x,y좌표

    void Awake()
    {
        slotWidth = (numberOfSlotWidth * slotSize) + (numberOfSlotWidth * slotGap) + slotGap;
        slotArea.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotWidth);

        slotHeight = (numberOfSlotHeight * slotSize) + (numberOfSlotHeight * slotGap) + slotGap;
        slotArea.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotHeight);

        for (int w = 0; w < numberOfSlotWidth; w++)
        {
            for (int h = 0; h < numberOfSlotHeight; h++)
            {
                GameObject slot = Instantiate(itemSlot) as GameObject;
                RectTransform slotC = slot.GetComponent<RectTransform>();
                RectTransform item = slot.transform.GetChild(0).GetComponent<RectTransform>();

                slot.name = "Slot Number" + numberOfSlotWidth + "." + numberOfSlotHeight;
                slot.transform.parent = transform;

                slotC.localPosition = new Vector3((slotSize * numberOfSlotWidth) + (slotGap * (numberOfSlotWidth + 1)),
                    -((slotSize * numberOfSlotHeight) + (slotGap * (numberOfSlotHeight + 1))),0);

                slotC.localScale = Vector3.one;
                slotC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotSize);
                slotC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotSize); 

                item.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotSize - slotSize * 0.5f);
                item.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotSize - slotSize * 0.5f);

                itemSlotManager.Add(slot);
            }
        }

    }
}
