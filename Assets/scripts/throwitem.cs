using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwitem : Item, IUseableItem
{
    

    public void Throw(Player user)
    {
        Debug.Log("���� ������Ʈ�� ����");
    }

    public void UseItem(Player user)
    {
        Throw(user);
    }


    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("������Ʈ�� ������ ����");
    }
}
