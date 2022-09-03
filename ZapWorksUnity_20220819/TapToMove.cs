using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            print(Input.mousePosition.x + "," + Input.mousePosition.y);
            //カメラ中心から視線方向のベクトルを取得
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //内積を計算
            float dot = Vector3.Dot(-transform.parent.up, ray.direction);
            //三角形の相似比(倍率)を求め、視線方向のベクトルに掛ける
            Vector3 pos = ray.origin + (ray.direction * (transform.parent.InverseTransformPoint(ray.origin).y / dot));
            //算出された座標をCGの位置に反映
            transform.position = pos;
        }
    }
}
