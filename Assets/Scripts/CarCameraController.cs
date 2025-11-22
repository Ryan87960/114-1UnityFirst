using UnityEngine;

public class CarCameraController : MonoBehaviour
{
    [SerializeField] private Transform car;            // 車子
    [SerializeField] private Transform firstPersonPos; // 第一人稱位置
    [SerializeField] private Transform thirdPersonPos; // 第三人稱位置
    private bool isFirstPerson = true;

    void Update()
    {
        // 切換視角（按下 C）
        if (Input.GetKeyDown(KeyCode.C))
        {
            isFirstPerson = !isFirstPerson;
        }

        // 更新攝影機位置
        if (isFirstPerson)
        {
            transform.position = firstPersonPos.position;
            transform.rotation = firstPersonPos.rotation;
        }
        else
        {
            transform.position = thirdPersonPos.position;
            transform.rotation = thirdPersonPos.rotation;
        }
    }
}
