using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresistentSingleton<T> : MonoBehaviour where T : Component
{
    public static T Instance { get; private set; }  // ���÷�����, ���Ա����������, ��ֻ��ͨ����������ֵ

    protected virtual void Awake()  // �ɱ�������д
    {
        if (Instance == null)
        {
            Instance = this as T;
        }
        else if (Instance != this)  // ����������³���, �����³������Ѿ���һ����������ͬ�ű�����Ϸ����ʱ
        {
            Destroy(gameObject);  // ��ԭ���ű����صĶ���ݻٵ�, ��ֹ����������ͬ�ľ�̬ʵ����ɳ�ͻ
        }

        DontDestroyOnLoad(gameObject);  // DontDestroyOnLoad()�����³���ʱ�������治Ҫ�ݻٲ���������Ķ���
    }
}
