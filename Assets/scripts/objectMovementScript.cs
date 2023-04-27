using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMovementScript : MonoBehaviour
{

    Vector3 coords1 = new Vector3(3, 3, 3);
    Vector3 coords2 = new Vector3(15, 3, 3);
    private float speed = 0.25f;
    public GameObject obj;
    public GameObject coltrig;
    public CharacterController player;
    private float t;
    // Start is called before the first frame update
    void Start()
    {
        obj.transform.position = Vector3.Lerp(coords1, coords2, t);
    }


    void Update()
    {
        t += Time.deltaTime * speed;
        obj.transform.position = Vector3.Lerp(coords1, coords2, t);
        if (t >= 1)
        {
            var b = coords2;
            var a = coords1;
            coords1 = b;
            coords2 = a;
            t = 0;
        }
    }
}
