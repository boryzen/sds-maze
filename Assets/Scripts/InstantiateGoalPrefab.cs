using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGoalPrefab : MonoBehaviour
{

    public MazeSpawner mazeSpawner;
    public GameObject GoalPrefab;

    private float[] column = {3.0f,5.0F,6.0F,7.5F,8.0F};
    private float[] row = { 3.0f, 5.0F, 6.0F, 7.5F, 8.0F };

    // Start is called before the first frame update
    void Start()
    {
        GameObject tmp;
         for (int i = 0; i < 5; i++)
        {

            float x = column[i] * (mazeSpawner.CellWidth + (mazeSpawner.AddGaps ? .2f : 0));
            float z = row[i] * (mazeSpawner.CellHeight + (mazeSpawner.AddGaps ? .2f : 0));

            tmp = Instantiate(GoalPrefab, new Vector3(x, 1, z), Quaternion.Euler(0, 0, 0));
            tmp.transform.parent = transform;
                    



        }
    }
}
