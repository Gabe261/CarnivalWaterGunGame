using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private List<string> targets;
    private float remainingLiquid;
    private List<string> streaks;

    public struct ScoreOutput
    {
        public List<string> targets;
        public float remainingLiquid;
        public List<string> streaks;
    }
    
    private ScoreOutput score;
    
    private void Awake()
    {
        targets = new List<string>();
        remainingLiquid = 0;
        streaks = new List<string>();
        
        //score = new ScoreOutput(targets, remainingLiquid, streaks);
        
    }
}
