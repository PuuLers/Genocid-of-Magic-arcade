using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LvlGenerator : MonoBehaviour
{
    public GameObject[] Rooms;
    public int LevLengthMax;
    public int LevLengthMin;
    public Transform Zero;
    public float pref;
    public GameObject BossRoom;
    public GameObject EndRoom;


    private int RandNumber(int max, int min)
    {
        int rand = Random.Range(max, min);
        return rand;
    }

    private void Generate()
    {
        int Lehght = RandNumber(LevLengthMin, LevLengthMax);
        for (int i = 0; i < Lehght; i++)
        {
            if (i < Lehght)
            {
                int rand = Random.Range(0, Rooms.Length);
                GameObject LastRoom = null;
                GameObject ActiveRoom = Rooms[rand];

                if (LastRoom == ActiveRoom && i != 0)
                {
                    i--;
                }
                else
                {
                    var Cell = Instantiate(ActiveRoom, Zero);
                    Cell.transform.localPosition = new Vector3(0, i * pref, 0);
                    LastRoom = ActiveRoom;
                }
            }
        }
        var boss = Instantiate(BossRoom, Zero);
        boss.transform.localPosition = new Vector3(0, Lehght * pref, 0);
        var end = Instantiate(EndRoom, Zero);
        end.transform.localPosition = new Vector3(0, (Lehght + 1) * pref, 0);
    }




    void Start()
    {
        Generate();

    }


}
