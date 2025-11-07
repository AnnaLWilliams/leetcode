public class Solution {
    public int HIndex(int[] citations) {
        var lastCorrectSize = 0;
        var minGuess = 0;
        var maxGuess = citations.Length + 1;
        var size = (int)Math.Ceiling(citations.Length / 2.0);
        do 
        {
            var count = 0;
            foreach(var citation in citations)
            {
                if (citation >= size)
                {
                    count++;
                }
            }

            if(count >= size)
            {
                lastCorrectSize = size;
                minGuess = size;
                size = (int)Math.Ceiling((maxGuess - minGuess) / 2.0) + size;
            }
            else
            {
                maxGuess = size;
                size = (int)Math.Ceiling((maxGuess - minGuess) / 2.0);
            }

            if (size == maxGuess)
            {
                return lastCorrectSize;
            }

        }while (true);
    }
}