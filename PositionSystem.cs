using DefaultEcs.System;

namespace SortedEntityExample;

public struct PositionInfo
{
    public int X;
    public int Y;
}

public sealed partial class PositionSystem : AEntitySortedSetSystem<int, PositionInfo>, IComparer<PositionInfo>
{
    public int Compare(PositionInfo x, PositionInfo y)
    {
        return x.X.CompareTo(y.X);
    }

    [Update]
    private void Update(int state, in PositionInfo positionInfo)
    {
    }
}