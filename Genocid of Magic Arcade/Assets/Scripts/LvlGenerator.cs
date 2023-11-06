using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGenerator : MonoBehaviour
{
    public GameObject[] Rooms;
    public int LevLength;
    public Transform Zero;
    public float pref;
    private GameObject LastRoom;
    public GameObject BossRoom;
    public GameObject EndRoom;

    private void Generate()
    {
        for (int i = 0; i < LevLength; i++)
        {
            int rand = Random.Range(0, Rooms.Length);
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
        Instantiate(BossRoom, Zero);
        BossRoom.transform.localPosition = new Vector3(0, LevLength * pref, 0);
        Instantiate(EndRoom, Zero);
        EndRoom.transform.localPosition = new Vector3(0, LevLength * pref + pref, 0);
    }




    void Start()
    {
        Generate();
    }


}
