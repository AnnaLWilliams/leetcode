/*
 * @lc app=leetcode id=211 lang=csharp
 *
 * [211] Design Add and Search Words Data Structure
 *
 * https://leetcode.com/problems/design-add-and-search-words-data-structure/description/
 *
 * algorithms
 * Medium (47.72%)
 * Likes:    7991
 * Dislikes: 489
 * Total Accepted:    829.3K
 * Total Submissions: 1.7M
 * Testcase Example:  '["WordDictionary","addWord","addWord","addWord","search","search","search","search"]\n' +
  '[[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]'
 *
 * Design a data structure that supports adding new words and finding if a
 * string matches any previously added string.
 * 
 * Implement the WordDictionary class:
 * 
 * 
 * WordDictionary() Initializes the object.
 * void addWord(word) Adds word to the data structure, it can be matched
 * later.
 * bool search(word) Returns true if there is any string in the data structure
 * that matches word or false otherwise. word may contain dots '.' where dots
 * can be matched with any letter.
 * 
 * 
 * 
 * Example:
 * 
 * 
 * Input
 * 
 * ["WordDictionary","addWord","addWord","addWord","search","search","search","search"]
 * [[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]
 * Output
 * [null,null,null,null,false,true,true,true]
 * 
 * Explanation
 * WordDictionary wordDictionary = new WordDictionary();
 * wordDictionary.addWord("bad");
 * wordDictionary.addWord("dad");
 * wordDictionary.addWord("mad");
 * wordDictionary.search("pad"); // return False
 * wordDictionary.search("bad"); // return True
 * wordDictionary.search(".ad"); // return True
 * wordDictionary.search("b.."); // return True
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= word.Length <= 25
 * word in addWord consists of lowercase English letters.
 * word in search consist of '.' or lowercase English letters.
 * There will be at most 2 dots in word for search queries.
 * At most 10^4 calls will be made to addWord and search.
 * 
 * 
 */

// @lc code=start
public class WordDictionary {
    Node tree;
    public WordDictionary() {
        tree = new Node("");
    }
    
    public void AddWord(string word) {
        if (tree.value == "")
        {
            tree.value = word;
        }
        else
        {
            var wordOrder = 0;
            var node = tree;
            //Find an empty branch
            while(true)
            {
                wordOrder = CalcWordOrder(node.value, word);

                if (wordOrder == -1)//a copy of the word has been found
                {
                    break;
                }
                else if (node.children[wordOrder] == null) //An empty branch for the word has been found
                {
                    node.children[wordOrder] = new Node(word);
                    break;
                }
                else //There is already a child node so move to that node
                {
                    node = node.children[wordOrder];
                }
            }
        }
    }

    public bool Search(string word)
    {
        var wordOrder = 0;
        var node = tree;
        while(true)
        {
            wordOrder = CalcWordOrder(node.value, word);

            if (wordOrder == -1)//a copy of the word has been found
            {
                return true;
            }
            else if (node.children[wordOrder] == null) //An empty branch has been found
            {
                return false;
            }
            else //There is already a child node so move to that node
            {
                node = node.children[wordOrder];
            }
        }
    }
    
    /// <summary>
    /// Checks the alphabetical order of two words
    /// </summary>
    /// <param name="rootWord"></param>
    /// <param name="branchWord"></param>
    /// <returns>
    /// -2 the word contains a dot so both branches need to be checked
    /// -1 = the words are the same
    /// 0 Branch word is alphabetically before Root word
    /// 1 Root word is alphabetically before Branch word
    /// </returns>
    public int CalcWordOrder(string rootWord, string branchWord)
    {
        for (var index = 0; index < rootWord.Length && index < branchWord.Length; index++)
        {
            if (branchWord[index] == '.')
            {
                return -2;
            }
            else if (rootWord[index] < branchWord[index])
            {
                return 1;
            }
            else if (rootWord[index] > branchWord[index])
            {
                return 0;
            }
        }

        //The start of the words are the same calculate based on Length
        if (rootWord.Length > branchWord.Length)
        {
            return 0;
        }
        else if (rootWord.Length < branchWord.Length)
        {
            return 1;
        }
        else
        {
            return -1;
        }


    }
}

public class Node
{
    public string value;
    public Node?[] children;

    public Node(string value)
    {
        this.value = value;
        children = new Node?[2];
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
// @lc code=end

