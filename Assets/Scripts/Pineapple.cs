using UnityEngine;

public class Pineapple : Item
{
    public override void UseItem(GameObject player)
    {
        player.GetComponent<PlayerInfo>().GetExp(itemData.itemValue);
    }
}
