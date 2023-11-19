public class GoalList
{
    public string _goalType;
    public string _goalName;
    public int _goalPoints;
    public int _currentAmount;
    public int _endAmount;
    public bool _completed = false;
    public string Display()
    {
        return $"{_goalType} ~|~ {_goalName} ~|~ {_goalPoints} ~|~ {_currentAmount} ~|~ {_endAmount} ~|~ {_completed}";
    }
}