
using UnityEngine;

public class RewardCalc : MonoBehaviour
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

       
        int goldPerPerson = gold / members;
        int leaderBonus = gold % members;

       
        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);

        
        int level = finalExp / 100 + 1;
        int nextExp = 100 - (finalExp % 100);

      
        float avgDamage = (float)totalDamage / hits;

        Debug.Log("플레이 시간 " + h + ":" + m.ToString("D2") + ":" + s.ToString("D2"));
        Debug.Log("1인당 " + goldPerPerson + "G, 리더 보너스 " + leaderBonus + "G");
        Debug.Log("경험치 " + finalExp + " (기본 " + baseExp + ")");
        Debug.Log("Lv " + level + ", 다음 레벨까지 " + nextExp);
        Debug.Log("평균 데미지 " + avgDamage);
    }
}
