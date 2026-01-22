using UnityEngine;

public class CountdownChallenge : MonoBehaviour
{
    int s = 10;
    public GameObject obj;
    int left;
    float tmr;

    void Start()
    {
        left = s;
        Debug.Log("Time left: " + left);
    }

    void Update()
    {
        tmr += Time.deltaTime;
        if (tmr >= 1f)
        {
            tmr = 0f;
            left--;
            Debug.Log("Time left: " + left);
            obj.SetActive(!obj.activeSelf);
            if (left <= 0)
            {
                Debug.Log("TIMES UP");
                enabled = false;
            }
        }
    }
}
