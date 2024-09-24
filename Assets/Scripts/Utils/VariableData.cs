using Utils;

public struct VariableData
{
    public Define.VariableType VariableType;
    public string VariableValue;

    public VariableData(Define.VariableType t, string v)
    {
        VariableType = t;
        VariableValue = v;
    }
}