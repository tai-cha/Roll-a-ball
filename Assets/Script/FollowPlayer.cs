using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; //ターゲットへの参照
    private Vector3 offset; // 相対座標

    void Start()
    {
        // 自分自身とtargetとの相対位置を求める
        offset = GetComponent<Transform>().position - target.position;
    }

    void Update()
    {
        // 自分の座標にtargetの座標を代入する
        GetComponent<Transform>().position = target.position + offset;
    }
}
