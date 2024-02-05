using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //创建预制体对象 在外界赋予
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //根据Prefab创建实例  实例化Prefab      
        //Instantiate:创建游戏物体  本质是克隆
        //position：位置  rotation：未知
        //GameObject.Instantiate(bulletPrefab,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //Input:与输入有关的类
        //GetMouseButtonDown:判断鼠标是否按下  0 左键  1右键
        if (Input.GetMouseButtonDown(0))
        {
            //接收新创建的游戏物体对象
            GameObject bullet = GameObject.Instantiate(bulletPrefab,transform.position,transform.rotation);
            //GetComponent：获取游戏物体的组件并接收
            Rigidbody rd = bullet.GetComponent<Rigidbody>();
            //rd.AddForce(Vector3.forward);
            //设置游戏物体的初速度
            rd.velocity = Vector3.forward * 35;
        }
    }
}
