using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fooditem : Item, IUseableItem
{
    public float nutrition;

    public void Eat(Player user)
    {
        Debug.Log("���� ������ ����");
    }

    public  void UseItem(Player user)
    {
        Eat(user);
    }

    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("�׸��� �Ա� ����� �߰���");
    }

}
