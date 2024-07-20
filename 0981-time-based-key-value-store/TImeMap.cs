public class TimeMap
{
   
    private Dictionary<string, List<(int timestamp, string value)>> map;

    public TimeMap()
    {
        map = new Dictionary<string, List<(int, string)>>();
    }
    
    public void Set(string key, string value, int timestamp)
    {
        if (!map.ContainsKey(key))
        {
            map[key] = new List<(int, string)>();
        }
        map[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp)
    {
        if (!map.ContainsKey(key))
        {
            return "";
        }

        var list = map[key];
        int left = 0, right = list.Count - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (list[mid].timestamp == timestamp)
            {
                return list[mid].value;
            }
            if (list[mid].timestamp < timestamp)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        
        return right >= 0 ? list[right].value : "";
    }
}
