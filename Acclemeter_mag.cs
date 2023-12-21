using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class Acclemeter_mag : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 acceleration;
    private Vector3 magneticField;

    public string move;

    public TMP_Text acc;
    //public Text acc;
    public TMP_Text mag;
    public TMP_Text dir;
    public TMP_Text debug;


    public string acclemeter;


    void Start()
    {
        Input.compass.enabled = true;
        Input.location.Start(10, 0.01f);

    }

    // Update is called once per frame
    void Update()
    {
        // 檢查加速度計和磁力計是否可用
        //if (SystemInfo.supportsAccelerometer)
        //{
            // 獲取加速度計和磁力計數據



            acceleration = Input.acceleration;
            //magneticField = Input.compass.rawVector;

            // 在控制台中輸出加速度計和磁力計數據
            //Debug.Log("Acceleration: " + acceleration);
            acc.GetComponent<TextMeshProUGUI>().text = acceleration.ToString();

            acclemeter = acceleration.ToString();


        //    Debug.Log("Magnetic Field: " + magneticField);
        //    mag.GetComponent<TextMeshProUGUI>().text = magneticField.ToString();

        //    // 估計方向
        //    Vector3 direction = EstimateDeviceDirection(acceleration, magneticField);


        //    // 在控制台中輸出估計的方向
        //    Debug.Log("Estimated Direction: " + direction);

        //    debug.GetComponent<TextMeshProUGUI>().text = "GO";

        //    // 獲取方向向量的 x、y、z 分量
        //    float x = direction.x;
        //    float y = direction.y;
        //    float z = direction.z;

        //    // 轉換為前後左右的移動方向（這只是一個簡單的示例）
        //    // 根據 x、y、z 分量的正負值，來判斷前後左右的移動方向
        //    if (Mathf.Abs(x) > Mathf.Abs(y) && Mathf.Abs(x) > Mathf.Abs(z))
        //    {
        //        if (x > 0)
        //        {
        //            // 移動方向為前
        //            move = "Moving Forward";
        //            Debug.Log("Moving Forward");
        //        }
        //        else
        //        {
        //            // 移動方向為後
        //            move = "Moving Forward";
        //            Debug.Log("Moving Forward");
        //        }
        //    }
        //    //else if (Mathf.Abs(y) > Mathf.Abs(x) && Mathf.Abs(y) > Mathf.Abs(z))
        //    //{
        //    //    if (y > 0)
        //    //    {
        //    //        // 移動方向為上
        //    //        move = "Moving Forward";
        //    //        Debug.Log("Moving Forward");
        //    //    }
        //    //    else
        //    //    {
        //    //        // 移動方向為下
        //    //        move = "Moving Down";
        //    //        Debug.Log("Moving Down");
        //    //    }
        //    //}
        //    else
        //    {
        //        if (z > 0)
        //        {
        //            // 移動方向為右
        //            move = "Moving Right";
        //            Debug.Log("Moving Right");
        //        }
        //        else
        //        {
        //            // 移動方向為左
        //            move = "Moving Left";
        //            Debug.Log("Moving Left");
        //        }
        //    }

        //    dir.GetComponent<TextMeshProUGUI>().text = move.ToString();
        //}
        //else
        //{
        //    acc.GetComponent<TextMeshProUGUI>().text = "None";
        //    mag.GetComponent<TextMeshProUGUI>().text = "None";
        //    dir.GetComponent<TextMeshProUGUI>().text = "None";

        //    Debug.Log("Accelerometer or Compass not supported");
        //    debug.GetComponent<TextMeshProUGUI>().text = "Accelerometer or Compass not supported";
        //}



    }
    //private Vector3 EstimateDeviceDirection(Vector3 accel, Vector3 mag)
    //{
    //    // 根據磁力計數據獲取北向（地球磁北）的方向
    //    Quaternion rotation = Quaternion.LookRotation(mag, -accel);

    //    // 將方向轉換為歐拉角度（俯仰、偏航、滾動）
    //    Vector3 euler = rotation.eulerAngles;

    //    // 返回估計的方向
    //    return new Vector3(-euler.x, euler.y, euler.z);
    //}
}
