try
{
    Console.WriteLine("Please enter a phrase to convert to an acronym:");
    String input = Console.ReadLine();

    if (input.Trim().Length == 0)
    {
        Console.WriteLine("Phrase can not be empty");
    }
    else
    {
        String exclusions = input.Replace("and", "").Replace("of", "");
        String[] wordArr = exclusions.Split(' ');

        String acronym = " ";

        for (int i = 0; i < wordArr.Length; i++)
        {
            if (wordArr[i] != "")
            {
                acronym += wordArr[i][0];
            }
        }
        acronym = acronym.ToUpper();

        Console.WriteLine("Your acronym is: " + acronym);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

