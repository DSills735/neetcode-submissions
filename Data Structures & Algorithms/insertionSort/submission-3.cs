public class Solution
{
    public List<List<Pair>> InsertionSort(List<Pair> pairs)
    {
        List<List<Pair>> states = new List<List<Pair>>();
    
        if (pairs == null || pairs.Count == 0)
        {
            return states;
        }

        for (int i = 0; i < pairs.Count; i++)
        {
            Pair current = pairs[i];
            int j = i - 1;

            while (j >= 0 && pairs[j].Key > current.Key)
            {
                pairs[j + 1] = pairs[j];
                j--;
            }
            
            pairs[j + 1] = current;
            List<Pair> currentState = new List<Pair>();
            foreach (var item in pairs)
            {
                currentState.Add(new Pair(item.Key, item.Value));
            }
            states.Add(currentState);
        }

        return states;
    }
}
