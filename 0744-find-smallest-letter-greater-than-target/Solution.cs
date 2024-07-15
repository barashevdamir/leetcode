public class Solution
{
    public char NextGreatestLetter(char[] letters, char target) {
        var leftIndex = 0;
        var rightIndex = letters.Length - 1;
        letters = strQuickSort(letters, leftIndex, rightIndex);
        while (leftIndex <= rightIndex)
        {
            var middleIndex = (leftIndex + rightIndex) / 2;
            if (letters[middleIndex] <= target)
            {
                leftIndex = middleIndex + 1;
            }
            else
            {
                rightIndex = middleIndex - 1;
            }
        }
        return letters[leftIndex % letters.Length];
    }

    private static char[] strQuickSort(char[] letters, int leftIndex, int rightIndex)
    {
        var pivot = letters[rightIndex];
        var i = leftIndex - 1;
        for (var j = leftIndex; j < rightIndex; j++)
        {
            if (letters[j].CompareTo(pivot) < 0)
            {
                i++;
                (letters[i], letters[j]) = (letters[j], letters[i]);
            }
        }
        (letters[i + 1], letters[rightIndex]) = (letters[rightIndex], letters[i + 1]);
        return letters;
        
    }
}