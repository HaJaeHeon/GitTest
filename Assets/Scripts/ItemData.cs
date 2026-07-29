using UnityEngine;

public enum ItemType
{
    Pineapple,
    Melon,
    Cherries
}

[CreateAssetMenu(menuName = "Game Data/Item Data")]
public class ItemData : ScriptableObject
{
    public int ItemId;
    public ItemType itemType;
    public string itemName;
    public float itemValue;
    public Sprite skillSprite;
}