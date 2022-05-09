using UnityEngine;

public class FlyingEar2 : MonoBehaviour
{

    private const int Y = 1;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Alpha1 key was pressed.");

            distance = 0;

            transform.Translate(0, 0, distance);
            transform.localPosition = new Vector3(0, Y, distance);

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Alpha2 key was pressed.");
            distance = 10;

            transform.Translate(0, 0, distance);
            transform.localPosition = new Vector3(0, Y, distance);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Alpha3 key was pressed.");

            distance = 20;

            transform.Translate(0, 0, distance);
            transform.localPosition = new Vector3(0, Y, distance);




        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("Alpha4 key was pressed.");

            distance = 30;

            transform.Translate(0, 0, distance);
            transform.localPosition = new Vector3(0, Y, distance);
        }
    }
}