using System;

public class Game
{
    private int CurrentScore = 0;
    private int[] Rolls = new int[21];
    private int CurrentRoll = 0;
    public void RollMany(int rolls, int pins)
    {
        for (int i = 0; i < rolls; i++)
        {
            Roll(pins);
        }
    }
    private void Roll(int pins)
    {
        CurrentScore += pins;
        Rolls[CurrentRoll++] = pins;
    }

    public object Score()
    {
        var score = 0;
        int roll = 0;
        for (int frame = 0; frame < 10; frame++)
        {
            if (IsSpare(roll))
            {
                score += 10 + Rolls[roll + 2];
                roll += 2;
            }
            else
            {
                score += Rolls[roll] + Rolls[roll + 1];
                roll += 2;
            }
        }
        return score;
    }
    private bool IsSpare(int roll)
    {
        return Rolls[roll] + Rolls[roll + 1] == 10;
    }
}