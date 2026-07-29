using UnityEngine;

public class Melon : Item
{
    public override void UseItem(GameObject player)
    {
        player.GetComponent<PlayerInfo>().GetExp(itemData.itemValue);
    }
}
