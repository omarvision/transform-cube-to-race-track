
public static class Globals
{
    public static int ControlType = 1;

    public static string SetControlType_GetDesc(int type)
    {
        ControlType = type;
        switch (ControlType)
        {
            case 1:
                return "Keyboard";
            case 2:
                return "Mouse";
            default:
                return ControlType.ToString();
        }
    }
}
