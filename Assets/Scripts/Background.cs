using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Hello Unity!");
        //2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] level = new int[3];
        level[0] = 1;
        level[1] = 6;
        level[2] = 20;
        for (int i = 0; i < level.Length; i++)��
        {
            Debug.Log(level[i]);
        }
        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

    }
    private float moveSpeed = 3f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
    }
}
