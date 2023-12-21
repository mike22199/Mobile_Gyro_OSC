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
        // �ˬd�[�t�׭p�M�ϤO�p�O�_�i��
        //if (SystemInfo.supportsAccelerometer)
        //{
            // ����[�t�׭p�M�ϤO�p�ƾ�



            acceleration = Input.acceleration;
            //magneticField = Input.compass.rawVector;

            // �b����x����X�[�t�׭p�M�ϤO�p�ƾ�
            //Debug.Log("Acceleration: " + acceleration);
            acc.GetComponent<TextMeshProUGUI>().text = acceleration.ToString();

            acclemeter = acceleration.ToString();


        //    Debug.Log("Magnetic Field: " + magneticField);
        //    mag.GetComponent<TextMeshProUGUI>().text = magneticField.ToString();

        //    // ���p��V
        //    Vector3 direction = EstimateDeviceDirection(acceleration, magneticField);


        //    // �b����x����X���p����V
        //    Debug.Log("Estimated Direction: " + direction);

        //    debug.GetComponent<TextMeshProUGUI>().text = "GO";

        //    // �����V�V�q�� x�By�Bz ���q
        //    float x = direction.x;
        //    float y = direction.y;
        //    float z = direction.z;

        //    // �ഫ���e�ᥪ�k�����ʤ�V�]�o�u�O�@��²�檺�ܨҡ^
        //    // �ھ� x�By�Bz ���q�����t�ȡA�ӧP�_�e�ᥪ�k�����ʤ�V
        //    if (Mathf.Abs(x) > Mathf.Abs(y) && Mathf.Abs(x) > Mathf.Abs(z))
        //    {
        //        if (x > 0)
        //        {
        //            // ���ʤ�V���e
        //            move = "Moving Forward";
        //            Debug.Log("Moving Forward");
        //        }
        //        else
        //        {
        //            // ���ʤ�V����
        //            move = "Moving Forward";
        //            Debug.Log("Moving Forward");
        //        }
        //    }
        //    //else if (Mathf.Abs(y) > Mathf.Abs(x) && Mathf.Abs(y) > Mathf.Abs(z))
        //    //{
        //    //    if (y > 0)
        //    //    {
        //    //        // ���ʤ�V���W
        //    //        move = "Moving Forward";
        //    //        Debug.Log("Moving Forward");
        //    //    }
        //    //    else
        //    //    {
        //    //        // ���ʤ�V���U
        //    //        move = "Moving Down";
        //    //        Debug.Log("Moving Down");
        //    //    }
        //    //}
        //    else
        //    {
        //        if (z > 0)
        //        {
        //            // ���ʤ�V���k
        //            move = "Moving Right";
        //            Debug.Log("Moving Right");
        //        }
        //        else
        //        {
        //            // ���ʤ�V����
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
    //    // �ھںϤO�p�ƾ�����_�V�]�a�y�ϥ_�^����V
    //    Quaternion rotation = Quaternion.LookRotation(mag, -accel);

    //    // �N��V�ഫ���کԨ��ס]�����B����B�u�ʡ^
    //    Vector3 euler = rotation.eulerAngles;

    //    // ��^���p����V
    //    return new Vector3(-euler.x, euler.y, euler.z);
    //}
}
