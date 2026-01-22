using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        float y = 0f;
        if (Input.GetKey(KeyCode.Space))
            y = 1f;
        else if (Input.GetKey(KeyCode.LeftShift))
            y = -1f;

        Vector3 m = new Vector3(h, y, v);
        GetComponent<CharacterController>().Move(m * speed * Time.deltaTime);
    }
}
