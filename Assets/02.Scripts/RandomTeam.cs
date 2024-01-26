using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomTeam : MonoBehaviour
{
    public string[] Students = new string[] { "김성준", "이태환", "김경희", "정수빈", "민예진", "이윤석", "정성훈", "고승연", "공지수", "조희수", "전민성", "이성민", "김예은" };
    public string[] NotTeam = new string[] { "이태환", "정성훈" };

    public Dictionary<int, List<string>> Teams;

    private bool _haveFourTeam = false;

    private int _teamCount = 4;

    public int Seed;

    private void Start()
    {
        UnityEngine.Random.InitState(Seed);

        while(TryRandomTeam())
        {
        }

        Debug.Log("팀 배정 종료");

        StartCoroutine(Show_Coroutine());
    }

    private IEnumerator Show_Coroutine()
    {
        var wait = new WaitForSeconds(13f);
        string result = string.Empty;

        for (int i = 0; i < _teamCount; i++)
        {
            yield return wait;

            result = string.Empty;

            foreach (string student in Teams[i])
            {
                result += $"{student} ";
            }

            Debug.Log($"{i + 1}팀: {result}");
        }
    }


    private bool TryRandomTeam()
    {
        int random1, random2;
        string temp;

        // 배열 셔플
        for (int i = 0; i < Students.Length; ++i)
        {
            random1 = Random.Range(0, Students.Length);
            random2 = Random.Range(0, Students.Length);

            temp = Students[random1];
            Students[random1] = Students[random2];
            Students[random2] = temp;
        }


        Teams = new Dictionary<int, List<string>>();
        for (int i = 0; i < _teamCount; i++)
        {
            Teams[i] = new List<string>();
        }


        int studentCount = Students.Length;
        for (int i = 0; i < studentCount; ++i)
        {
            string student = Students[i];

            int maxCount = _haveFourTeam ? 3 : 4;
            while (true)
            {
                int randomTeam = Random.Range(0, _teamCount);

                if (Teams[randomTeam].Count < maxCount)
                {
                    Teams[randomTeam].Add(student);

                    if (Teams[randomTeam].Count >= 4)
                    {
                        _haveFourTeam = true;
                    }

                    break;
                }
            }
        }

        for (int i = 0; i < _teamCount; i++)
        {
            int c = Teams[i].Count(s => NotTeam.Contains(s));
            if(c >= 2)
            {
                return true;
            }
        }



        return false;
    }


   
}
