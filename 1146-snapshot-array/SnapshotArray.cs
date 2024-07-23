public class SnapshotArray
{
    private int snapId;
    private List<List<int[]>> snapshots;

    public SnapshotArray(int length)
    {
        snapId = 0;
        snapshots = new List<List<int[]>>(length);
        for (int i = 0; i < length; i++)
        {
            snapshots.Add(new List<int[]> { new int[] { 0, 0 } });
        }
    }

    public void Set(int index, int val)
    {
        snapshots[index].Add(new int[] { snapId, val });
    }

    public int Snap()
    {
        return snapId++;
    }

    public int Get(int index, int snap_id)
    {
        List<int[]> snapshot = snapshots[index];
        int left = 0, right = snapshot.Count;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (snapshot[mid][0] <= snap_id)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return snapshot[left - 1][1];
    }
}