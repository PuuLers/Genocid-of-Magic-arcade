using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGenerator : MonoBehaviour
{
    public GameObject[] Rooms;
    private int _LevLength;
    public int LevLengthMax;
    public int LevLengthMin;
    public Transform Zero;
    public float pref;
    private GameObject _LastRoom;
    public GameObject BossRoom;
    public GameObject EndRoom;


    private void LevLengthGenerate()
    {
        int rand = Random.Range(LevLengthMin, LevLengthMax);
        _LevLength = rand;
    }

    private void Generate()
    {
        LevLengthGenerate();
        for (int i = 0; i < _LevLength; i++)
        {
            if (i < _LevLength - 2) 
            {

                int rand = Random.Range(0, Rooms.Length);
                GameObject ActiveRoom = Rooms[rand];

                if (_LastRoom == ActiveRoom && i != 0)
                {
                    i--;
                }
                else
                {
                    var Cell = Instantiate(ActiveRoom, Zero);
                    Cell.transform.localPosition = new Vector3(0, i * pref, 0);
                    _LastRoom = ActiveRoom;
                }
                if (i == _LevLength -2)
                {
                    var Cell = Instantiate(BossRoom, Zero);
                    Cell.transform.localPosition = new Vector3(0, i * pref, 0);
                }
                else if (i == _LevLength -1)
                {

                }
            }
        }
    }




    void Start()
    {
        Generate();
        Debug.Log(_LevLength);
    }


}
