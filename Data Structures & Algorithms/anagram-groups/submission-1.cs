public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length <= 1)
        {
            List<List<string>> list = new List<List<string>>();
            var strsList = strs.ToList();
            list.Add(strsList);

            return list;
        }

        int[] count = new int[26];
        List<List<string>> result = new List<List<string>>();


        for (int i = 0; i < strs.Length; i++)
        {
            var wordReference = strs[i]; 
            var currentWordList = new List<string>();


            for (int j = i + 1; j < strs.Length; j++)
            {
                var wordComparation = strs[j];            
                Array.Clear(count, 0, count.Length);

                var c = result.Any(r => r.Contains(wordReference));

                if(wordReference.Length == wordComparation.Length && !c)
                {
                    for (int x = 0; x < wordReference.Length; x++)
                    {
                        count[wordReference[x] - 'a']++;
                        count[wordComparation[x] - 'a']--;
                    }

                    var isAngram = count.All(a => a == 0);

                    if (isAngram)
                    {
                        currentWordList.Add(wordComparation);
                    }
                }

                if (j == strs.Length -1 && !c)
                {
                    currentWordList.Add(wordReference);
                    result.Add(currentWordList);
                }
            }

            var con = result.Any(r => r.Contains(wordReference));

            if (i == strs.Length - 1 && !con)
            {
                currentWordList.Add(wordReference);
                result.Add(currentWordList);
            }
        }

        return result;
    }
}
