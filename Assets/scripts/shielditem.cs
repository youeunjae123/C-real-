using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shielditem : Item, IUseableItem
{
    

    public void Shield(Player user)
    {
        Debug.Log("���� ���з� ������ ����");
    }

    public void UseItem(Player user)
    {
        Shield(user); // ���� ��Ŭ���ϸ� ������ ����
    }


    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("���з� ������ �ְԵ�");
    }
}
