using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //����Ԥ������� ����縳��
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //����Prefab����ʵ��  ʵ����Prefab      
        //Instantiate:������Ϸ����  �����ǿ�¡
        //position��λ��  rotation��δ֪
        //GameObject.Instantiate(bulletPrefab,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //Input:�������йص���
        //GetMouseButtonDown:�ж�����Ƿ���  0 ���  1�Ҽ�
        if (Input.GetMouseButtonDown(0))
        {
            //�����´�������Ϸ�������
            GameObject bullet = GameObject.Instantiate(bulletPrefab,transform.position,transform.rotation);
            //GetComponent����ȡ��Ϸ��������������
            Rigidbody rd = bullet.GetComponent<Rigidbody>();
            //rd.AddForce(Vector3.forward);
            //������Ϸ����ĳ��ٶ�
            rd.velocity = Vector3.forward * 35;
        }
    }
}
