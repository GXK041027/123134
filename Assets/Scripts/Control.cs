using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    //�������飬�������ֹ���
    public GameObject[] monsters;
    public GameObject activeMonster = null;
    // Start is called before the first frame update
    void Start()
    {
        //�������飬��֤������ʧ��ȡ����ײ��
        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<BoxCollider>().enabled = false;
            monster.SetActive(false);
        }
        //����
        ActivateMonster();
    }

    private void ActivateMonster()
    {
        int index = Random.Range(0, monsters.Length);
        activeMonster = monsters[index];
        activeMonster.SetActive(true);
        activeMonster.GetComponent<BoxCollider>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
