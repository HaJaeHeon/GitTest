using UnityEngine;


public class Cherries : Item
{
    public override void UseItem(GameObject player)
    {
        player.GetComponent<PlayerInfo>().Heal(itemData.itemValue);
    }
}

