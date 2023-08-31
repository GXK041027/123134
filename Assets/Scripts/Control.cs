using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    //创建数组，储存四种怪物
    public GameObject[] monsters;
    public GameObject activeMonster = null;
    // Start is called before the first frame update
    void Start()
    {
        //遍历数组，保证怪物消失和取消碰撞体
        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<BoxCollider>().enabled = false;
            monster.SetActive(false);
        }
        //激活
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
