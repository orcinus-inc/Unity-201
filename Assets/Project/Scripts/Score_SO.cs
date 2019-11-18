using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "VinceUtils/Score", order = 1)]
public class Score : ScriptableObject
{
    public List<Player> player;
    public int score;
}

[System.Serializable]
public class Player
{
    // Start is called before the first frame update


}
