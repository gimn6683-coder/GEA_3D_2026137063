using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public int 
        playSeconds = 3725,
        gold = 1234, 
        members = 4, 
        kills = 7, 
        expPerKill = 35, 
        totalDamage = 250,
        hits = 20;

    public float expRate = 1.5f;


    [ContextMenu("정산")]
    public void Settle()
    {
        int h = playSeconds / 3600;
        int m = playSeconds % 3600 / 60;
        int s = playSeconds % 60;

        Debug.Log("플레이 시간: " + h + "시간 " + m + "분 " + s + "초 ");



    }

}
