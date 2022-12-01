namespace BASICS
{
  // String
  public class BASICS16
  {
    public static void MainCode()
    {
      char[] chars = { 'w', 'o', 'r', 'd' };
      sbyte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x00 };

      // Create a string from a character array
      string string1 = new string(chars);
      Console.WriteLine("string1 = {0}", string1);

      // Create a string that consists of a character repeated 20 times
      string string2 = new string('c', 20);
      Console.WriteLine("string2 = {0}", string2);

      string stringFromBytes = null;
      string stringFromChars = null;
      unsafe
      {
        fixed (sbyte* pbytes = bytes)
        {
          // Create a string from a pointer to a signed byte array
          stringFromBytes = new string(pbytes);
        }
        fixed (char* pchars = chars)
        {
          // Create a string from a pointer to a character array
          stringFromChars = new string(pchars);
        }
      }

      Console.WriteLine("stringFromBytes = {0}", stringFromBytes);
      Console.WriteLine("stringFromChars = {0}", stringFromChars);

      // Concatenate strings using + operator
      string today = "Today is " + DateTime.Now.ToString("D") + ".";
      Console.WriteLine(today);

      string sentences = "This is the first sentence. " + "This is the second.";
      sentences += " This is the third sentence.";
      Console.WriteLine(sentences);

      // Extract string from string
      string sentence = "This sentence has five words.";
      // Extract the second word
      int startPosition = sentence.IndexOf(" ") + 1;
      string word2 = sentence.Substring(startPosition, sentence.IndexOf(" ", startPosition) - startPosition);

      Console.WriteLine("Second word: " + word2);

      // String.Format
      DateTime dateAndTime = new DateTime(2022, 7, 6, 7, 32, 0);
      double temperature = 68.3;
      string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.", dateAndTime, temperature);

      Console.WriteLine(result);

      // Char can be extracted using index
      string anotherSentence = "This string consists of a single short sentence.";
      int numberOfWords = 0;

      anotherSentence = anotherSentence.Trim();
      for (int ctr = 0; ctr < anotherSentence.Length; ctr++)
      {
        if (Char.IsPunctuation(anotherSentence[ctr]) | Char.IsWhiteSpace(anotherSentence[ctr]))
          numberOfWords++;
      }

      Console.WriteLine("The sentence\n\t{0}\nhas {1} words.",
                        anotherSentence, numberOfWords);

      // isNullOrEmpty(string) == if (str == null) || str.Equals(String.Empty)
      // isNullOrWhiteSpace(string) == if (str == null) || str.Equals(String.Empty || str.Trim().Equals(String.Empty))

      CreatePattern1();
      CreatePattern1('#');
      CreatePattern1('-', 9);
      CreatePattern1('!', 7);

      CreatePattern2();
      CreatePattern2('#');
      CreatePattern2('-', 9);
      CreatePattern2('!', 7);

      CharSet();
      CharSet(128, 255);
      CharSet(128, 255, 10);
      Console.WriteLine();

      /********************************************/

      string statement = " nowhere ";
      Console.WriteLine(statement);
      Console.WriteLine(statement.Length);
      Console.WriteLine(statement.Trim());
      Console.WriteLine(statement.Trim().Length);
      Console.WriteLine(statement.TrimStart());
      Console.WriteLine(statement.TrimEnd());
      Console.WriteLine(statement.ToLower());
      Console.WriteLine(statement.ToUpper());
      Console.WriteLine(statement.Replace('e', 'a'));
    }

    public static void CreatePattern1(char c = '*', int n = 5)
    {
      for (int i = 0; i <= n; i++)
      {
        Console.WriteLine("{0, 10}", new string(c, i));
      }
    }

    public static void CreatePattern2(char c = '$', int n = 4)
    {
      for (int i = n; i >= 0; i--)
      {
        Console.WriteLine("{0, 10}", new string(c, i));
      }
    }

    public static void CharSet(int startIndex = 60, int finishIndex = 90, int numberOfCharsInRow = 5)
    {
      for (int i = startIndex; i <= finishIndex; i++)
      {
        Console.Write("{0, 5}", (char)i);
        if (i % numberOfCharsInRow == 0)
        {
          Console.WriteLine();
        }
      }
    }
  }
}