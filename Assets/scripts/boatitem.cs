using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatitem : Item, IUseableItem
{
    

    public void Boat(Player user)
    {
        Debug.Log("���� ��Ŭ���ϸ� ���� �迡 Ż�� ����");
    }

    public void UseItem(Player user)
    {
        Boat(user); // �踦 ��ġ�ϰ� ž��
    }


    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("��Ʈ�� ��ġ�Ҽ� ����");
    }
}
