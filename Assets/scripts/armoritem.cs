using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armoritem : Item, IUseableItem
{
    

    public void Armor(Player user)
    {
        Debug.Log("������ �������� ����");
    }

    public void UseItem(Player user)
    {
        Armor(user); // ������ ����
    }


    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("�׸��� �������� �߰���");
    }
}