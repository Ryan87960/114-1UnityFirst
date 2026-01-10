using UnityEngine;

public class FindNPC : MonoBehaviour
{
    public float 最長距離 = 5.0f;
    GameObject 目標敵人 = null;
    GameObject[] 所有敵人;
    public GameObject 玩家;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 取得所有敵人
        GameObject[] 所有敵人 = GameObject.FindGameObjectsWithTag("Enemy");

        // 2. 初始化判斷變數
        目標敵人 = null;
        float 最短距離 = Mathf.Infinity; // 必須從無限大開始，否則 10f 可能不夠
        float 最長距離 = 5.0f; // 題目要求的距離限制

        // 3. 尋找最近的敵人
        foreach (GameObject 敵人 in 所有敵人)
        {
            float 距離 = Vector3.Distance(玩家.transform.position, 敵人.transform.position);
            if (距離 < 最短距離)
            {
                最短距離 = 距離;
                目標敵人 = 敵人;
            }
        }

        // 4. 判斷最近的敵人是否在 5 公尺內
        // 這裡一定要先檢查 目標敵人 != null，否則會報錯
        if (目標敵人 != null && 最短距離 <= 最長距離)
        {
            Vector3 瞄準位置 = 目標敵人.transform.position;
            瞄準位置.y = 1.45f;
            this.transform.position = 瞄準位置;
            Debug.Log("找到敵人: " + 目標敵人.name);
        }
        else
        {
            // 如果找不到或太遠，將目標清空
            目標敵人 = null;
            // Debug.Log("範圍內沒有敵人");
        }
    }
}
