using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMoment : MonoBehaviour
{
    public int speed = 2;//设置默认速度
    // Start is called before the first frame update
    void Start()
    {
        //transform组件  
        //直接使用一些默认组件就可以获取本物体上的该组件
        //Translate方法：变换方法（变换物体位置）
        //transform.Translate(Vector3.left);
    }

    // Update is called once per frame
    void Update()
    {
        //获取水平运动方法 AD 
        float h = Input.GetAxis("Horizontal");
        //获取上下运动方法
        float v = Input.GetAxis("Vertical");
        //获取前后运动方法 自己设置的
        float g = Input.GetAxis("GoAndOut");
        //进行运动
        transform.Translate(new Vector3(h,v,g)*Time.deltaTime*speed);
        //加入Time.deltaTime:控制镜头的移动速度（一次一帧的速度）
        //speed：控制镜头1S行动的速度
        //获取上一次被调用到下一被调用花费的时间
        //Time.deltaTime 
        //运用1/Time.deltaTime得到的数字就是帧数即FPS，用于判定游戏流畅度
    }
    ////设置固定更新次数方法
    //private void FixedUpdate()
    //{
        
    //}
}
