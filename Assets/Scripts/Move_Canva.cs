using UnityEngine;

public class moveCar : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;     // 前進速度
    [SerializeField] private float turnSpeed = 100f;   // 轉彎速度
    public bool lockY = true; // 是否鎖定Y軸



    void Update()
    {
        // 前後移動（W、S 或 上、下鍵）
        float move = 0f;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            move = 1f;
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            move = -1f;

        // 左右轉向（A、D 或 左、右鍵）
        float turn = 0f;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            turn = -1f;
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            turn = 1f;

        // 移動 & 轉向
        transform.Translate(Vector3.forward * move * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * turn * turnSpeed * Time.deltaTime);
    }
}
