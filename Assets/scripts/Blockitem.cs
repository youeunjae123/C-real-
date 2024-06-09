using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockitem : Item , IUseableItem
{
    public void PlaceBlock(Player user, Vector2 pos)
    {
        Debug.Log("���� ���� ��ġ��");
    }


    public  void UseItem(Player user)
    {
        PlaceBlock(user,transform.position);
    }


    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("�׸��� ��ġ ����� �߰���");
    }
}
