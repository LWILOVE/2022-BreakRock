using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMoment : MonoBehaviour
{
    public int speed = 2;//����Ĭ���ٶ�
    // Start is called before the first frame update
    void Start()
    {
        //transform���  
        //ֱ��ʹ��һЩĬ������Ϳ��Ի�ȡ�������ϵĸ����
        //Translate�������任�������任����λ�ã�
        //transform.Translate(Vector3.left);
    }

    // Update is called once per frame
    void Update()
    {
        //��ȡˮƽ�˶����� AD 
        float h = Input.GetAxis("Horizontal");
        //��ȡ�����˶�����
        float v = Input.GetAxis("Vertical");
        //��ȡǰ���˶����� �Լ����õ�
        float g = Input.GetAxis("GoAndOut");
        //�����˶�
        transform.Translate(new Vector3(h,v,g)*Time.deltaTime*speed);
        //����Time.deltaTime:���ƾ�ͷ���ƶ��ٶȣ�һ��һ֡���ٶȣ�
        //speed�����ƾ�ͷ1S�ж����ٶ�
        //��ȡ��һ�α����õ���һ�����û��ѵ�ʱ��
        //Time.deltaTime 
        //����1/Time.deltaTime�õ������־���֡����FPS�������ж���Ϸ������
    }
    ////���ù̶����´�������
    //private void FixedUpdate()
    //{
        
    //}
}
