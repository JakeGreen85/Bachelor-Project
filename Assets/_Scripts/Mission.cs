using System.Collections;
using UnityEngine;

public class Mission
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Streak {  get; private set; }
    public int Score { get; private set; }
    public bool Completed { get; private set; }
    public Mission(string name, string desc, int streak, int score)
    {
        this.Name = name;
        this.Description = desc;
        this.Streak = streak;
        this.Score = score;
    }

    public void completed()
    {
        this.Completed = true;
    }
}