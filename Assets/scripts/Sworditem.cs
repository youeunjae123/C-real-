using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sworditem : Item , IUseableItem
{
    public int damage;

    public void Attack(Player user, Transform enemy)
    {
        Debug.Log("���� ������ ������");
    }

    public  void UseItem(Player user)
    {
        Attack(user, null);
    }


    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("�׸��� ó�� ����� �߰���");
    }
}
